using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulsFormats;
using Microsoft.VisualBasic.FileIO;
using System.Numerics;
using System.Diagnostics;
using static EldenRingSpiritBattler.SpiritBattlerResources;

namespace EldenRingSpiritBattler
{
    public partial class MainForm : Form
    {
        public bool preventEnemyEdited = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Button_Execute.Enabled = false;
            b_restoreRegulation.Enabled = false;
            Text += GetVersion();

            SetRandomTeamName();

            teamDict = new()
            {
                { "Summons", new SpiritTeam("Summons", (int)PhantomEnum.C19, (int)StatScalingEnum.None, (byte)TeamTypeEnum.SpiritSummon) },
                { "Invaders", new SpiritTeam("Invaders", (int)PhantomEnum.C60, (int)StatScalingEnum.None, (byte)TeamTypeEnum.Invader) },
                { "Enemies", new SpiritTeam("Enemies", (int)PhantomEnum.None, (int)StatScalingEnum.None, (byte)TeamTypeEnum.Enemy) },
            };

            List_StatScaling.DataSource = GetOrderedEnumNames(typeof(StatScalingEnum));

            LoadSpiritAshResource();
            LoadEnemyResource();
            LoadTeamsResource();
            LoadTeamTypeResource();
            LoadPhantomResource();

            // Add an initial random BattleSpirit to the grid.
            AddRandomEnemyToGrid();
        }

        private void EnemyWasEdited(object sender, EventArgs e)
        {
            if (preventEnemyEdited)
                return;
            UpdateSelectedSpirit();
        }

        private void b_restoreRegulation_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete Regulation.bin and restore backup?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Restore_Regulation();
        }

        private void b_browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string? directory = Path.GetDirectoryName(openFileDialog1.FileName);
                if (File.Exists(directory + "\\eldenring.exe"))
                {
                    // User is loading the regulation next to eldenring.exe, yell at them

                    DialogResult result = MessageBox.Show("Warning: Modifying the Regulation.bin directly used by Elden Ring is ill-advised."
                        + " \nIt's highly recommended you instead use Mod Engine 2 and place a copy of Regulation.bin into the Mod folder."
                        + " \n\nAre you sure you want to load this Regulation.bin anyway?"
                        , "Confirm Regulation.bin Selection", MessageBoxButtons.OKCancel);
                    if (result != DialogResult.OK)
                    {
                        Button_Execute.Enabled = false;
                        return;
                    }
                }

                Button_Execute.Enabled = true;

                UpdateConsole("Loaded Regulation.bin");

                backupFile = directory + "/regulation.bin.backup"; //place backup next to regulation.bin

                if (File.Exists(backupFile))
                    b_restoreRegulation.Enabled = true;
            }
        }

        private void Button_PickRandomEnemy_Click(object sender, EventArgs e)
        {
            SelectRandomEnemyAndSetToElements();
            EnemyWasEdited(sender, e);
        }

        private void Button_SetDataSelection_Click(object sender, EventArgs e)
        {
            UpdateSelectedSpirit();
        }

        private void Button_RandomTeamName_Click(object sender, EventArgs e)
        {
            SetRandomTeamName();
        }

        private void Button_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Hover over an option to see what it does.\n\n" +
                "Step 1: Locate your Elden Ring installation and find Regulation.bin.\n" +
                "Step 2: Copy and paste regulation.bin into your Mod Engine 2 \"Mod\" folder.\n" +
                "Step 3: Use this tool to browse and load the copied regulation.bin.\n" +
                "Step 4: Create teams and enemies as desired, then choose which Spirit Ash to overwrite.\n" +
                "Step 5: Save Changes. The selected ash should now be changed in-game.\n" +
                "\nMade by King Bore Haha / Geeeeeorge"
                , "Info", MessageBoxButtons.OK);
        }

        private void Button_RemoveSpiritFromList_Click(object sender, EventArgs e)
        {
            if (SpiritDataGrid.Rows.Count <= 1)
            {
                // Don't let number of rows drop below 1
                return;
            }
            battleSpiritList.Remove(GetSpiritGridSelection()!);

            UpdateSpiritGrid();
        }
        private void Button_AddNewTeam_Click(object sender, EventArgs e)
        {
            teamDict[Input_TeamName.Text] = CreateSpiritTeam();
            LoadTeamsResource();
        }

        private void Button_GetDataSelection_Click(object sender, EventArgs e)
        {
            GetLoadedGridSpiritInfo();
        }


        private void Button_StatScalingLevelInfo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Stat scaling is a vanilla system that scales enemies stats, and is generally applied per-area.\n\n" +
                "Open stat scaling information spreadsheet in browser?"
                , "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process myProcess = new();
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "https://docs.google.com/spreadsheets/d/1Cj1ZT2VH-rjWddqDSY0zTvNZfolZlXAHqhrdnTQe7hQ/edit#gid=1042523006";
                myProcess.Start();
            }
        }

        private void Button_DuplicateSpirit_Click(object sender, EventArgs e)
        {
            // Get data from selected spirit in summon grid and duplicate it
            if (SpiritDataGrid.SelectedRows.Count == 0)
                return;

            battleSpiritList.Add(((BattleSpirit)SpiritDataGrid.SelectedRows[0].Cells[0].Value).Clone());

            UpdateSpiritGrid();
        }

        private void Button_Execute_Click(object sender, EventArgs e)
        {
            /*
            if (File.Exists(backupFile))
            {
                //User wants to randomize a regulation that has a backup file next to it

                DialogResult result = MessageBox.Show("Warning: Backup Regulation.bin already exists."
                    + " \nYou may be trying to randomize an already randomized Regulation.bin, which will cause issues. It's recommended you restore the backup first."
                    + " \n\nDelete Regulation.bin and restore backup before proceeding?"
                    , "Confirm Randomization", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.OK)
                {
                    Restore_Regulation();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            */

            if (ExecuteMainLogic())
            {
                // Success
                GC.Collect(); // Free memory
                UpdateConsole("Save Successful");
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("Saved Successfully!", "Finished", MessageBoxButtons.OK);
            }
            else
            {
                // Failure
                GC.Collect(); // Free memory
                UpdateConsole("Save Failed");
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("Save Failed.", "Error", MessageBoxButtons.OK);
            }
        }
        private void SpiritDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Spirit grid right-click functionality
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    SpiritDataGrid.ClearSelection();
                    SpiritDataGrid.Rows[rowSelected].Selected = true;
                }
            }
        }

        private void ComboBox_KeyPress(object sender, KeyEventArgs e)
        {
            // Jank way to make ComboBoxes not take keyboard inputs
            ActiveControl = SpiritDataGrid;
        }

        private void SpiritDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetLoadedGridSpiritInfo();
        }

        private void Option_ReduceEnemyMapCol_clicked(object sender, EventArgs e)
        {
            Option_ReduceEnemyMapCol.Checked = !Option_ReduceEnemyMapCol.Checked;
        }

        private void Option_SpiritAshNoRequirements_Click(object sender, EventArgs e)
        {
            Option_SpiritAshNoRequirements.Checked = !Option_SpiritAshNoRequirements.Checked;
            if (Option_SpiritAshNoRequirements.Checked == false)
                MessageBox.Show("This option is not reversable if you have already executed with this option.\nRestore backups if you want to undo this.", "Warning");
        }

        private void Option_DisableFriendlyFire_Click(object sender, EventArgs e)
        {
            Option_DisableFriendlyFire.Checked = !Option_DisableFriendlyFire.Checked;
        }

        private void List_Enemy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (enemyVariantDict.TryGetValue(List_Enemy.Text, out List<Enemy> list))
            {
                List_EnemyVariant.DataSource = list.Select(e => e.Name).ToList();
                // Update NpcParamId and NpcThinkParam elements
                Input_NpcParamID.Value = enemyVariantDict[List_Enemy.Text][0].NpcID;
                Input_NpcThinkID.Value = enemyVariantDict[List_Enemy.Text][0].ThinkID;
            }
            EnemyWasEdited(sender, e);
        }

        private void List_EnemyVariant_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update NpcParamId and NpcThinkParam elements
            Input_NpcParamID.Value = enemyVariantDict[List_Enemy.Text][List_EnemyVariant.SelectedIndex].NpcID;
            Input_NpcThinkID.Value = enemyVariantDict[List_Enemy.Text][List_EnemyVariant.SelectedIndex].ThinkID;
        }

        private void Button_AddRandomEnemy_Click(object sender, EventArgs e)
        {
            preventEnemyEdited = true;

            AddRandomEnemyToGrid();

            SpiritDataGrid.ClearSelection();
            SpiritDataGrid.Rows[SpiritDataGrid.Rows.Count - 1].Selected = true;

            preventEnemyEdited = false;
        }
    }
}
