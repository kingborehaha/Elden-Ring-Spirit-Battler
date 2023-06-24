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
        public string RegulationPath = "";

        public MainForm()
        {
            InitializeComponent();
        }

        public void LoadConfig()
        {
            Config = UserConfig.Load();
            Option_ReduceEnemyMapCol.Checked = Config.ReduceEnemyCollisionRadii;
            Option_EnableResummoning.Checked = Config.EnableResummoning;
            Option_MoreSummonAreas.Checked = Config.ExpandSummonAreas;
            Option_HidePlayer.Checked = Config.HidePlayer;
        }

        public bool IsStartup = true;

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadConfig();
            string summonBackupPath = $@"{Directory.GetCurrentDirectory()}\Summon Backups";
            Directory.CreateDirectory(summonBackupPath);
            FileDialog_SaveJson.InitialDirectory = summonBackupPath;
            FileDialog_LoadJson.InitialDirectory = summonBackupPath;

            Button_Execute.Enabled = false;
            b_restoreRegulation.Enabled = false;
            Text += GetVersion();

            AddRandomizedTeamToGrid(TeamTypeEnum.Beast, teamSummonPresetDict["Column Left"]);
            AddRandomizedTeamToGrid(TeamTypeEnum.DS3_CoopMadPhantom, teamSummonPresetDict["Column Right"]); //Tried hostileNPC
            AddRandomizedTeamToGrid(TeamTypeEnum.SpiritSummon, teamSummonPresetDict["Row Close"]);
            AddRandomizedTeamToGrid(TeamTypeEnum.Enemy, teamSummonPresetDict["Row Far"]);

            List_StatScaling.DataSource = GetOrderedEnumNames(typeof(StatScalingEnum));
            List_StatScaling.Text = StatScalingEnum.Lvl15.ToString();

            LoadSpiritAshResource();
            LoadEnemyResource();
            UpdateTeamGridAndList();
            UpdateTeamElements();
            LoadTeamTypeResource();
            LoadPhantomResource();


            AddRandomSpiritToGrid();
            List_EnemyChosenTeam.Text = teamDict.Values.Where(e => e.TeamPosition.Label == "Column Left").First().Name;
            AddRandomSpiritToGrid();
            List_EnemyChosenTeam.Text = teamDict.Values.Where(e => e.TeamPosition.Label == "Column Right").First().Name;
            UpdateTeamElements();

            List_TeamSummonPreset.DataSource = teamSummonPresetDict.Keys.ToList();

            Option_Spirit_SearchesLongRange.Enabled = !Option_SummonsEasilyFindTargets.Checked;

            IsStartup = false;
            EnemyWasEdited(sender, e);
        }

        private void EnemyWasEdited(object sender, EventArgs e)
        {
            if (preventEnemyEdited || IsStartup)
                return;
            UpdateSelectedSpirit();
            UpdateSpiritElements();
        }

        private void b_restoreRegulation_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete Regulation.bin and restore backup?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Restore_Regulation();
        }

        private void b_browse_Click(object sender, EventArgs e)
        {
            if (FileDialog_Regulation.ShowDialog() == DialogResult.OK)
            {
                string? directory = Path.GetDirectoryName(FileDialog_Regulation.FileName);
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
            SetRandomTeamName();
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

        private void UpdateSelectedTeam(object sender, EventArgs e)
        {
            if (!IsStartup && !_noUpdateTeam)
            {
                SpiritTeam team = CreateTeamFromElements();
                AddUpdateTeamToGrid(team);
                UpdateSpiritGrid();
            }
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
            preventEnemyEdited = true;
            Search_Enemy.Text = "";
            UpdateSpiritElements();
            preventEnemyEdited = false;
        }

        private void Option_ReduceEnemyMapCol_clicked(object sender, EventArgs e)
        {
            Option_ReduceEnemyMapCol.Checked = !Option_ReduceEnemyMapCol.Checked;
            Config.ReduceEnemyCollisionRadii = Option_ReduceEnemyMapCol.Checked;
        }

        private void List_Enemy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (enemyVariantDict.TryGetValue(List_Enemy.Text, out List<Enemy>? list))
            {
                List_EnemyVariant.DataSource = list.Select(e => e.Name).ToList();
                // Update NpcParamId and NpcThinkParam elements
                Input_NpcParamID.Value = enemyVariantDict[List_Enemy.Text][0].NpcID;
                Input_NpcThinkID.Value = enemyVariantDict[List_Enemy.Text][0].ThinkID;
                Input_CharaInitID.Value = enemyVariantDict[List_Enemy.Text][0].CharaInitID;
            }
            EnemyWasEdited(sender, e);
        }

        private void List_EnemyVariant_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update NpcParam, NpcThinkParam, and CharaInit elements
            if (List_Enemy.Text != "" && List_EnemyVariant.Text != "")
            {
                Input_NpcParamID.Value = enemyVariantDict[List_Enemy.Text].Find(e => e.Name == List_EnemyVariant.Text).NpcID;
                Input_NpcThinkID.Value = enemyVariantDict[List_Enemy.Text].Find(e => e.Name == List_EnemyVariant.Text).ThinkID;
                Input_CharaInitID.Value = enemyVariantDict[List_Enemy.Text].Find(e => e.Name == List_EnemyVariant.Text).CharaInitID;
                EnemyWasEdited(sender, e);
            }
        }

        private void Button_AddRandomEnemy_Click(object sender, EventArgs e)
        {
            AddRandomSpiritToGrid();
            //List_EnemyChosenTeam.Text = ((SpiritTeam)TeamDataGrid.SelectedRows[0].Cells[0].Value).Name;
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

        private void TeamDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateTeamElements();
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

            UpdateSelectedTeam(sender, e);
        }

        private void List_EnemyChosenTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnemyWasEdited(sender, e);
        }

        private void Search_Enemy_TextChanged(object sender, EventArgs e)
        {
            string str = Search_Enemy.Text;
            List_Enemy.Enabled = true;
            List_EnemyVariant.Enabled = true;

            if (str == "" || preventEnemyEdited)
            {
                Label_SearchEnemyText.Visible = true;
                List_Enemy.DataSource = enemyListCache;
            }
            else
            {
                Label_SearchEnemyText.Visible = false;
                List<string> results = enemyListCache.FindAll(s => s.Contains(str, StringComparison.CurrentCultureIgnoreCase));
                foreach (var en in enemyVariantDict)
                {
                    // Scan through variants for matches too
                    if (en.Value.Find(e => e.Name.Contains(str, StringComparison.CurrentCultureIgnoreCase)) != null)
                    {
                        results.Add(en.Key);
                    }
                }

                if (results.Count == 0)
                {
                    List_Enemy.Enabled = false;
                    List_EnemyVariant.Enabled = false;
                }
                else
                {
                    List_Enemy.DataSource = results;

                    List<string> variantResults = enemyVariantDict[List_Enemy.Text].FindAll(s => s.Name.Contains(str, StringComparison.CurrentCultureIgnoreCase)).Select(e => e.Name).ToList();
                    List_EnemyVariant.DataSource = variantResults;
                }
            }
        }

        private void Option_HidePlayer_Click(object sender, EventArgs e)
        {
            Option_HidePlayer.Checked = !Option_HidePlayer.Checked;
            Config.HidePlayer = Option_HidePlayer.Checked;
        }

        private void Search_Enemy_Click(object sender, EventArgs e)
        {
            Search_Enemy.SelectionStart = 0;
            Search_Enemy.SelectionLength = Search_Enemy.Text.Length;
        }

        private void Label_SearchText_Click(object sender, EventArgs e)
        {
            Search_Enemy.Focus();
            Search_Enemy_Click(sender, e);
        }

        private void Option_Randomize_PhantomColor_Click(object sender, EventArgs e)
        {
            Random rand = new();
            List_TeamPhantomColor.SelectedIndex = rand.Next(0, List_TeamPhantomColor.Items.Count - 1);

            UpdateSelectedTeam(sender, e);
        }

        private void Search_SpiritAsh_TextChanged(object sender, EventArgs e)
        {
            string str = Search_SpiritAsh.Text;
            List_SpiritAsh.Enabled = true;
            Label_SearchSpiritAshText.Visible = true;

            if (str == "")
            {
                Label_SearchEnemyText.Visible = true;
                List_SpiritAsh.DataSource = spiritAshesCache;
            }
            else
            {
                Label_SearchSpiritAshText.Visible = false;
                List<string> results = spiritAshesCache.FindAll(s => s.Contains(str, StringComparison.CurrentCultureIgnoreCase));

                if (results.Count == 0)
                {
                    List_SpiritAsh.Enabled = false;
                }
                else
                {
                    List_SpiritAsh.DataSource = results;
                }
            }
        }

        private void Label_SearchSpiritAshText_Click(object sender, EventArgs e)
        {
            Search_SpiritAsh.Focus();
            Search_SpiritAsh_Click(sender, e);
        }

        private void Search_SpiritAsh_Click(object sender, EventArgs e)
        {
            Search_SpiritAsh.SelectionStart = 0;
            Search_SpiritAsh.SelectionLength = Search_SpiritAsh.Text.Length;
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Q: Enemies aren't attacking eachother!\n" +
                "A: If Seamless Coop is installed, that will cause issues.\n" +
                "\n" +
                "Q: What are Team Types?\n" +
                "A: Team Types determine who summons will attack and who they can deal damage to. Using default team types is encouraged.\n" +
                "\n"
                , "FAQ", MessageBoxButtons.OK);
        }

        private void Button_SaveSummonBackup_Click(object sender, EventArgs e)
        {
            if (FileDialog_SaveJson.ShowDialog() == DialogResult.OK)
            {
                SpiritSaveLoad.Save(FileDialog_SaveJson.FileName, battleSpiritList, teamDict.Values.ToList());
                MessageBox.Show("Summon backup has been saved.", "Finished", MessageBoxButtons.OK);
            }
        }

        private void Button_LoadSummonBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileDialog_LoadJson.ShowDialog() == DialogResult.OK)
                {
                    if (MessageBox.Show("Are you sure you want to load this summon backup? All data currently in the program will be deleted.", "Overwrite current data", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        var save = SpiritSaveLoad.Load(FileDialog_LoadJson.FileName);

                        battleSpiritList = save.Spirits;
                        teamDict = new();
                        foreach (var team in save.Teams)
                        {
                            teamDict[team.Name] = team;
                        }

                        preventEnemyEdited = true;
                        UpdateTeamGridAndList();
                        UpdateSpiritGrid();
                        preventEnemyEdited = false;

                        MessageBox.Show("Summon backup has been loaded.", "Finished", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Newtonsoft.Json.JsonException ex)
            {
                MessageBox.Show($"Summon backup couldn't be loaded.\n\n{ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserConfig.Save(Config);
        }

        private void Option_EnableResummoning_Click(object sender, EventArgs e)
        {
            Option_EnableResummoning.Checked = !Option_EnableResummoning.Checked;
            Config.EnableResummoning = Option_EnableResummoning.Checked;
        }

        private void Option_MoreSummonAreas_Click(object sender, EventArgs e)
        {
            Option_MoreSummonAreas.Checked = !Option_MoreSummonAreas.Checked;
            Config.ExpandSummonAreas = Option_MoreSummonAreas.Checked;
        }

        private void Option_SummonsEasilyFindTargets_Click(object sender, EventArgs e)
        {
            Option_SummonsEasilyFindTargets.Checked = !Option_SummonsEasilyFindTargets.Checked;
            Config.SummonsFindTargetsEasily = Option_SummonsEasilyFindTargets.Checked;

            Option_Spirit_SearchesLongRange.Enabled = !Option_SummonsEasilyFindTargets.Checked;
        }
    }
}
