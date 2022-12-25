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

            // TODO: figure out non-lame teamtypes
            // TODO: order isn't consistent! waaat
            AddRandomizedTeamToGrid(TeamTypeEnum.Enemy, teamSummonPresetDict["Column Left"]);
            AddRandomizedTeamToGrid(TeamTypeEnum.DS3_CoopMadPhantom, teamSummonPresetDict["Column Right"]);
            AddRandomizedTeamToGrid(TeamTypeEnum.SpiritSummon, teamSummonPresetDict["Row Close"]);
            AddRandomizedTeamToGrid(TeamTypeEnum.Unknown24, teamSummonPresetDict["Row Far"]);

            List_StatScaling.DataSource = GetOrderedEnumNames(typeof(StatScalingEnum));
            List_StatScaling.Text = StatScalingEnum.Level_15.ToString();

            LoadSpiritAshResource();
            LoadEnemyResource();
            UpdateTeamGridAndList();
            SetGridTeamToElements();
            LoadTeamTypeResource();
            LoadPhantomResource();

            AddRandomSpiritToGrid();
            List_EnemyChosenTeam.Text = teamDict.Values.Where(e => e.TeamPosition.Label == "Column Left").First().Name;
            AddRandomSpiritToGrid();
            List_EnemyChosenTeam.Text = teamDict.Values.Where(e => e.TeamPosition.Label == "Column Right").First().Name;
            SetGridTeamToElements();

            List_TeamSummonPreset.DataSource = teamSummonPresetDict.Keys.ToList();
        }

        private void EnemyWasEdited(object sender, EventArgs e)
        {
            if (preventEnemyEdited)
                return;
            UpdateSelectedSpirit();
            SetSelectedSpiritToElements();
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

                backupFileName = directory + "/regulation.bin.backup"; //place backup next to regulation.bin

                if (File.Exists(backupFileName))
                    b_restoreRegulation.Enabled = true;
            }
        }

        private void Button_PickRandomEnemy_Click(object sender, EventArgs e)
        {
            SelectRandomSpiritAndSetToElements();
            EnemyWasEdited(sender, e);
        }

        private void Button_RandomizeTeam_Click(object sender, EventArgs e)
        {
            Random rand = new();
            SetRandomTeamName();
            List_TeamPhantomColor.SelectedIndex = rand.Next(0, List_TeamPhantomColor.Items.Count - 1);
        }

        private void Button_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Hover over an option to see what it does.\n\n" +
                "Step 1: Locate your Elden Ring installation and find regulation.bin.\n" +
                "Step 2: Copy and paste regulation.bin into your Mod Engine 2 \"Mod\" folder.\n" +
                "Step 3: Use this tool to browse and load the copied regulation.bin.\n" +
                "Step 4: Create teams and enemies as desired, then choose which Spirit Ash to overwrite.\n" +
                "Step 5: Save Changes. The selected ash should now be changed in-game.\n" +
                "\nMade by King Bore Haha / Geeeeeorge"
                , "Info", MessageBoxButtons.OK);
        }

        private void Button_DeleteSpiritFromList_Click(object sender, EventArgs e)
        {
            DeleteSelectedSpiritFromGrid();
        }

        private void Button_AddUpdateTeam_Click(object sender, EventArgs e)
        {
            SpiritTeam team = CreateTeamFromElements();
            AddUpdateTeamToGrid(team);
            UpdateSpiritGrid();
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

            int prevIndex = -1;
            if (SpiritDataGrid.SelectedRows.Count > 0)
                prevIndex = SpiritDataGrid.SelectedRows[0].Index;

            BattleSpirit spirit = ((BattleSpirit)SpiritDataGrid.SelectedRows[0].Cells[0].Value).Clone();
            bool success = InsertSpiritToList(spirit, battleSpiritList.IndexOf(GetSpiritGridSelection()!) + 1);
            if (success)
            {
                SpiritDataGrid.ClearSelection();
                SpiritDataGrid.Rows[prevIndex + 1].Selected = true;
            }
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
            // Right-click functionality
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
            SetSelectedSpiritToElements();
        }

        private void Option_ReduceEnemyMapCol_clicked(object sender, EventArgs e)
        {
            Option_ReduceEnemyMapCol.Checked = !Option_ReduceEnemyMapCol.Checked;
        }

        private void List_Enemy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (enemyVariantDict.TryGetValue(List_Enemy.Text, out List<Enemy>? list))
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
            EnemyWasEdited(sender, e);
        }

        private void Button_AddRandomEnemy_Click(object sender, EventArgs e)
        {
            AddRandomSpiritToGrid();
        }

        private void Button_DuplicateTeam_Click(object sender, EventArgs e)
        {
            // Get data from selected team and duplicate it
            if (TeamDataGrid.SelectedRows.Count == 0)
                return;

            SpiritTeam team = GetSelectedTeamFromGrid().Clone();
            team.Name = GetRandomUnusedTeamName();
            AddUpdateTeamToGrid(team);
        }
        private void Button_DeleteTeam_Click(object sender, EventArgs e)
        {
            // Don't let number of rows drop below 1
            if (TeamDataGrid.Rows.Count <= 1)
                return;

            SpiritTeam team = GetSelectedTeamFromGrid();
            foreach (DataGridViewRow row in SpiritDataGrid.Rows)
            {
                BattleSpirit spirit = (BattleSpirit)row.Cells[0].Value;
                if (spirit.Team == team)
                {
                    // A spirit is using this team, don't allow deletion.
                    MessageBox.Show("Cannot delete this team, it is being used.", "Error");
                    return;
                }
            }
            teamDict.Remove(team.Name);
            UpdateTeamGridAndList();
        }

        private void TeamDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Right-click functionality
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    TeamDataGrid.ClearSelection();
                    TeamDataGrid.Rows[rowSelected].Selected = true;
                }
            }
        }

        private void TeamDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SetGridTeamToElements();
        }

        private void Option_TargetAllSpiritAshes_CheckedChanged(object sender, EventArgs e)
        {
            List_SpiritAsh.Enabled = !Option_TargetAllSpiritAshes.Checked;
        }

        private void List_TeamSummonPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            SummonPos? teamPos = teamSummonPresetDict[List_TeamSummonPreset.Text];
            if (teamPos != null)
            {
                Input_TeamSummonPos_X.Enabled = false;
                Input_TeamSummonPos_Z.Enabled = false;
                Input_TeamSummonPos_Ang.Enabled = false;
            }
            else
            {
                Input_TeamSummonPos_X.Enabled = true;
                Input_TeamSummonPos_Z.Enabled = true;
                Input_TeamSummonPos_Ang.Enabled = true;
            }
        }

        private void List_EnemyChosenTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnemyWasEdited(sender, e);
        }

        private void Search_Enemy_TextChanged(object sender, EventArgs e)
        {
            string str = Search_Enemy.Text;
            List<string> resultList = new();
            var results = enemyListCache.FindAll(s => s.Contains(str, StringComparison.CurrentCultureIgnoreCase)).ToList();
            foreach (var en in enemyVariantDict)
            {
                if (en.Value.Find(e => e.Name.Contains(str, StringComparison.CurrentCultureIgnoreCase)) != null)
                {
                    resultList.Add(en.Key);
                }
            }
            List_Enemy.DataSource = resultList;
        }

        private void Option_HidePlayer_Click(object sender, EventArgs e)
        {
            Option_HidePlayer.Checked = !Option_HidePlayer.Checked;
        }
    }
}
