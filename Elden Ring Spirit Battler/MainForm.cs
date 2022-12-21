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

/*
-- TODO
summon positioning
randomize an entire ash
do DSMS style of project folder/game folder instead of just targeted selected regulation.bin?
save/load .json for battleSpiritList.
    automatically save on execute just so that data isn't lost on exceptions. that would be annoying.

-- Figure out
Hide player from enemies option
    Hop into roleParam, change player teamtype to neutral ghost?
        make sure to change hollow and human params!
--low priority
    change targeted ash name's FMG name
        format: "Spirit Battler: [team] vs [team]
    custom phantom colors
*/


namespace EldenRingSpiritBattler
{
    public partial class MainForm : Form
    {
        public string backupFile = "";

        public uint buddyLimit = 33; //TODO: confirm

        public Dictionary<string, int> spiritAshesDict = new();
        //public Dictionary<string, Enemy> enemyDict = new();
        public Dictionary<string, List<Enemy>> enemyVariantDict = new();
        public List<BattleSpirit> battleSpiritList = new();
        public Dictionary<string, SpiritTeam> teamDict;

        public MainForm()
        {
            InitializeComponent();
        }

        public void SetRandomTeamName()
        {
            Random rand = new();
            if (rand.Next(1, 42069) == 1)
                Input_TeamName.Text = "Prod's Feet Enjoyers";
            else
                Input_TeamName.Text = randomTeamNames[rand.Next(0, randomTeamNames.Length)];
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

            if (Button_ToggleAutoGetSpiritSettings.Checked)
            {
                // Add an initial random BattleSpirit to the grid.
                SelectRandomEnemyAndSetToElements();
                AddSpiritToGrid();
            }
        }

        public void SelectRandomEnemyAndSetToElements()
        {
            Random rand = new();
            List_Enemy.SelectedIndex = rand.Next(0, List_Enemy.Items.Count - 1);
            List_EnemyVariant.SelectedIndex = rand.Next(0, List_EnemyVariant.Items.Count - 1);
        }

        public string[] GetOrderedEnumNames(Type enumType)
        {
            // Order by enum value
            return Enum.GetNames(enumType).OrderBy(e => Enum.Parse(enumType, e)).ToArray();
        }

        private void SearchList()
        {

        }

        private int GetLongestCharInList(object list)
        {
            string[] strs = (string[])list;
            int count = 0;
            foreach (var s in strs)
            {
                var c = s.Length;
                if (c > count)
                    count = c;
            }
            return count*8;
        }

        private void LoadPhantomResource()
        {
            List_TeamPhantomColor.DataSource = GetOrderedEnumNames(typeof(PhantomEnum));
            List_TeamPhantomColor.DropDownWidth = GetLongestCharInList(List_TeamPhantomColor.DataSource);
        }
        private void LoadTeamTypeResource()
        {
            List_TeamType.DataSource = GetOrderedEnumNames(typeof(TeamTypeEnum));
            List_TeamType.DropDownWidth = GetLongestCharInList(List_TeamType.DataSource);
        }

        private void LoadEnemyResource()
        {
            try
            {
                var file = File.ReadAllLines($@"{AppDomain.CurrentDomain.BaseDirectory}\Resources\EnemyInfoResource.txt");

                string variantKey = "";
                for (var i = 0; i < file.Length; i++)
                {
                    var line = file[i];
                    if (line.StartsWith("--"))
                    {
                        // Start of a new enemy section
                        if (i + 1 >= file.Length)
                            break;

                        string nextLine = file[i + 1];
                        if (nextLine.Count(c => c == '|') != 4)
                            continue;

                        //variantKey = nextLine.Split("||")[0]; // Choose key name based on next valid line (first entry in new category)
                        variantKey = line[2..]; // Choose key name based on current line post-comment.
                        enemyVariantDict[variantKey] = new List<Enemy>();
                        continue;
                    }
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    var split = line.Split("||");
                    Enemy newEnemy = new(split[0], int.Parse(split[1]), int.Parse(split[2]));
                    enemyVariantDict[variantKey].Add(newEnemy);
                }
                List_Enemy.DataSource = enemyVariantDict.Keys.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("Error loading \"Resources\\EnemyInfoResource.txt\"", e);
            }
        }

        private void LoadSpiritAshResource()
        {
            try
            {
                spiritAshesDict.Clear();
                var file = File.ReadAllLines($@"{AppDomain.CurrentDomain.BaseDirectory}\Resources\SpiritAshResource.txt");

                foreach (var line in file)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;
                    if (line.StartsWith("--"))
                        continue;

                    var split = line.Split("||");
                    spiritAshesDict[split[1]] = int.Parse(split[0]);
                }
                List_SpiritAsh.DataSource = spiritAshesDict.Keys.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("Error loading \"Resources\\EnemyInfoResource.txt\"", e);
            }
        }
        private void LoadTeamsResource()
        {
            List_Teams.DataSource = teamDict.Select(e => e.Value.Name).ToList();
        }

        private static string GetTime()
        {
            string time = DateTime.Now.ToString("MM.dd.yyyy HH-mm-ss");
            return time;
        }

        private static string GetVersion()
        {
            string version = Application.ProductVersion;
            version = string.Format(" {0}", version);
            return version;
        }

        private static PARAM.Row InsertParamRow(PARAM param, PARAM.Row row, int newID)
        {
            PARAM.Row newRow = new PARAM.Row(newID, "buddyRando " + newID, param.AppliedParamdef);

            for (var i = 0; i < row.Cells.Count; i++)
            {
                newRow.Cells[i].Value = row.Cells[i].Value;
            }
            param.Rows.Insert(param.Rows.IndexOf(row) + 1, newRow);

            return newRow;
        }

        private void InsertSpecialEffect(PARAM.Row npcRow, int spEffectID)
        {
            for (var iEffect = 0; iEffect <= 31; iEffect++)
            {
                PARAM.Cell cell = npcRow["spEffectID" + iEffect];
                if ((int)cell.Value != -1)
                {
                    cell.Value = spEffectID;
                    return;
                }
            }
            throw new Exception($"Ran out of unused SpEffectID slots in npcParam for ID {npcRow.ID}");
        }


        private bool ExecuteMainLogic()
        {
            if (SpiritDataGrid.Rows.Count == 0)
            {
                MessageBox.Show("No summons have been added to the summon list.", "Error", MessageBoxButtons.OK);
                return false;
            }

            #region Load Parameters from Regulation.bin
            Dictionary<string, PARAM> paramList = new();
            string regulationPath = openFileDialog1.FileName;

            UpdateConsole("Checking Backup");
            if (!File.Exists(backupFile))
            {
                // No backup file exists
                UpdateConsole("Creating Backup");
                File.Copy(openFileDialog1.FileName, backupFile);
                b_restoreRegulation.Enabled = true;
            }

            UpdateConsole("Decrypting Regulation");

            BND4 paramBND = SFUtil.DecryptERRegulation(regulationPath); // Load and decrypt param regulation

            UpdateConsole("Loading ParamDefs");

            List<PARAMDEF> paramdefs = new();
            foreach (string path in Directory.GetFiles("Paramdex", "*.xml"))
            {
                var paramdef = PARAMDEF.XmlDeserialize(path);
                paramdefs.Add(paramdef);
            }

            UpdateConsole("Handling Params");

            foreach (BinderFile file in paramBND.Files)
            {
                string name = Path.GetFileNameWithoutExtension(file.Name);
                var param = PARAM.Read(file.Bytes);

                if (param.ApplyParamdefCarefully(paramdefs))
                    paramList[name] = param;
            }

            PARAM buddyParam;
            PARAM npcParam;
            PARAM npcThinkParam;
            PARAM goodsParam;
            PARAM spEffectParam;
            try
            {
                buddyParam = paramList["BuddyParam"];
                npcParam = paramList["NpcParam"];
                npcThinkParam = paramList["NpcThinkParam"];
                goodsParam = paramList["EquipParamGoods"];
                spEffectParam = paramList["SpEffectParam"];
            }
            catch
            {
                MessageBox.Show("Required parameters couldn't be loaded. Make sure this program and Elden Ring are updated.\nIf both are up to date and Elden Ring was recently updated, please report this issue.");
                throw;
            }
            #endregion

            UpdateConsole("Modifying Params");

            var selectedBuddyRowID = spiritAshesDict[List_SpiritAsh.Text];
            PARAM.Row targetBuddyRow = buddyParam[selectedBuddyRowID];

            foreach (var buddyRow in buddyParam.Rows.ToList())
            {
                // Clean targeted Spirit Ash
                if (selectedBuddyRowID - buddyRow.ID > 99)
                {
                    // This is not related to the targeted row
                    continue;
                }
                if (buddyRow.ID % 100 != 0)
                {
                    // Row is for an additional buddy, nuke it
                    buddyParam.Rows.Remove(targetBuddyRow);
                }
            }

            for (var i = 0; i < battleSpiritList.Count; i++)
            {
                var spirit = battleSpiritList[i];

                #region SpEffectParam

                // If the battleSpirit has special scaling, create a new spEffectParam row with the values and assign it to the battleSpirit.
                if (spirit.HpMult != 1 && spirit.DamageMult != 1)
                {
                    int baseEffectID = 290000;
                    int newEffectID = baseEffectID + 1000; // 291000
                    do
                    {
                        newEffectID++;
                    }
                    while (spEffectParam[newEffectID] != null);
                    PARAM.Row newSpEffectRow = InsertParamRow(spEffectParam, spEffectParam[baseEffectID], newEffectID);
                    newSpEffectRow.Name = $"Spirit Battler Special Scaling ({spirit.VariantName})";
                    float hpMult = spirit.HpMult;
                    float damMult = spirit.DamageMult;
                    newSpEffectRow["maxHpRate"].Value = hpMult;
                    newSpEffectRow["physicsAttackPowerRate"].Value = damMult;
                    newSpEffectRow["magicAttackPowerRate"].Value = damMult;
                    newSpEffectRow["fireAttackPowerRate"].Value = damMult;
                    newSpEffectRow["thunderAttackPowerRate"].Value = damMult;
                    newSpEffectRow["darkAttackPowerRate"].Value = damMult;
                    newSpEffectRow["registPoizonChangeRate"].Value = 1.0f;
                    newSpEffectRow["registDiseaseChangeRate"].Value = 1.0f;
                    newSpEffectRow["registBloodChangeRate"].Value = 1.0f;
                    newSpEffectRow["registFreezeChangeRate"].Value = 1.0f;
                    newSpEffectRow["registSleepChangeRate"].Value = 1.0f;
                    newSpEffectRow["registMadnessChangeRate"].Value = 1.0f;

                    spirit.Sp_SpecialScaling = newSpEffectRow.ID;
                }
                #endregion

                #region NpcParam
                int npcID = spirit.BaseNpcID;
                int newNpcID = npcID;
                if (npcParam[npcID] == null)
                {
                    MessageBox.Show($"Spirit {spirit.VariantName}'s base NpcParamID {npcID} cannot be found. Please fix this enemy.", "Error");
                    return false;
                }
                do
                {
                    newNpcID++;
                }
                while (npcParam[newNpcID] != null);
                PARAM.Row newNpcRow = InsertParamRow(npcParam, npcParam[npcID], newNpcID);

                newNpcRow["teamType"].Value = spirit.Team;
                newNpcRow["phantomShaderId"].Value = spirit.Team.PhantomShaderID;
                newNpcRow["itemLotId_enemy"].Value = -1;
                newNpcRow["itemLotId_map"].Value = -1;
                newNpcRow["GameClearSpEffectID"].Value = -1;
                newNpcRow["getSoul"].Value = (uint)0;

                // Cap map hit radii to prevent spawning issues
                if (Option_ReduceEnemyMapCol.Checked)
                {
                    float maxHitRadius = 1;
                    float maxHitHeight = 5;
                    if ((float)newNpcRow["hitRadius"].Value > maxHitRadius)
                    {
                        newNpcRow["hitRadius"].Value = maxHitRadius;
                    }
                    if ((float)newNpcRow["hitHeight"].Value > maxHitHeight)
                    {
                        newNpcRow["hitHeight"].Value = maxHitHeight;
                    }
                }
                if (Option_DisableFriendlyFire.Checked)
                {
                    newNpcRow["npcType"].Value = (byte)0;
                }

                // NpcParam Special Effects
                // TODO: organize scaling effect, and phantom param effect
                //int[] buddyEffects = { 295000, 296000, 297000 }; // (randomizer) special effects to be inserted into new npcParam

                var buddyEffects = spirit.SpecialEffects;
                int iBuddy = 0;
                for (var iEffect = 0; iEffect <= 31; iEffect++)
                {
                    int effectID = (int)newNpcRow["spEffectID" + iEffect].Value;
                    if (spirit.Sp_StatScaling != (int)StatScalingEnum.Default
                        && effectID >= 7000 && effectID < 7700)
                    {
                        // Vanilla scaling spEffect. Remove it
                        newNpcRow["spEffectID" + iEffect].Value = -1;
                    }

                    if (effectID == -1 && iBuddy < buddyEffects.Count)
                    {
                        // Slot is empty, insert effect
                        newNpcRow["spEffectID" + iEffect].Value = buddyEffects[iBuddy];
                        iBuddy++;
                    }
                }
                if (iBuddy < buddyEffects.Count)
                {
                    MessageBox.Show($"Not enough free SpEffect slots in NpcParam ID {spirit.BaseNpcID}.\nPlease report this issue and ID.", "Error", MessageBoxButtons.OK);
                    return false;
                }
                #endregion


                #region NpcThinkParam
                int npcThinkID = spirit.BaseThinkID;
                int newNpcThinkID = npcThinkID;
                if (npcThinkParam[npcThinkID] == null)
                {
                    MessageBox.Show($"Spirit {spirit.VariantName}'s base NpcThinkParamID {npcThinkID} cannot be found. Please fix this enemy.", "Error");
                    return false;
                }
                do
                {
                    newNpcThinkID++;
                }
                while (npcThinkParam[newNpcThinkID] != null);
                PARAM.Row newNpcThinkRow = InsertParamRow(npcThinkParam, npcThinkParam[npcThinkID], newNpcThinkID);

                // TODO
                // eye dist, battleStartDist, forget time, backHomeDist

                //newNpcThinkRow["isBuddyAI"].Value = false;
                #endregion

                #region BuddyParam
                PARAM.Row buddyParamRow = InsertParamRow(buddyParam, targetBuddyRow, targetBuddyRow.ID + i);

                buddyParamRow["npcParamId"].Value = newNpcRow.ID;
                buddyParamRow["npcThinkParamId"].Value = newNpcThinkRow.ID;
                buddyParamRow["npcPlayerInitParamId"].Value = -1; // Probably for c0000

                buddyParamRow["appearOnAroundSekihi"].Value = (byte)0; // 0 = Summon using player location
                buddyParamRow["pcFollowType"].Value = (byte)1; // 0 = Follow player around, 1 = No special behavior (?), 2 = ?

                buddyParamRow["x_offset"].Value = spirit.Position.X; // Horizontal offset 1
                buddyParamRow["z_offset"].Value = spirit.Position.Z; // Horizontal offset 2
                buddyParamRow["y_angle"].Value = spirit.Position.Ang;

                for (var ii = 0; ii <= 10; ii++)
                {
                    buddyParamRow["dopingSpEffect_lv" + ii].Value = -1;
                }
                buddyParamRow["npcParamId_ridden"].Value = -1;
                buddyParamRow["npcThinkParamId_ridden"].Value = -1;
                buddyParamRow["generateAnimId"].Value = -1;
                #endregion

                #region GoodsParam
                if (Option_SpiritAshNoRequirements.Checked)
                {
                    foreach (PARAM.Row row in goodsParam.Rows)
                    {
                        if (row.ID >= 200000 && row.ID <= 270000) //can probably replace this with good type check, or a sort ID check or something. ashes are distinguished in the UI somehow, after all.
                        {
                            // This is a spirit ash good
                            row["consumeHP"].Value = (Int16)0;
                            row["consumeMP"].Value = (Int16)0;
                        }
                    }
                }
                #endregion
            }

            UpdateConsole("Exporting Params");

            //output regulation
            foreach (BinderFile file in paramBND.Files)
            {
                string name = Path.GetFileNameWithoutExtension(file.Name);
                if (paramList.ContainsKey(name))
                    file.Bytes = paramList[name].Write();
            }

            //SFUtil.EncryptERRegulation(regulationPath, paramBND); //encrypt and write param regulation // TODO: save testing

            return true;
        }

        public void UpdateConsole(string text)
        {
            t_console.Text = text;
            Application.DoEvents();
        }

        private void Restore_Regulation()
        {
            string regulationPath = openFileDialog1.FileName;

            FileSystem.DeleteFile(regulationPath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
            if (!File.Exists(backupFile))
            {
                MessageBox.Show($"Failed to restore backup as \"{backupFile}\" could not be found.", "Error", MessageBoxButtons.OK);
                UpdateConsole("Backup Restoration Failed");
                b_restoreRegulation.Enabled = false;
            }
            else
            {
                File.Move(backupFile, regulationPath, false);
                UpdateConsole("Backup Restored");
                b_restoreRegulation.Enabled = false;
            }

        }

        private void GetLoadedGridSpiritInfo()
        {
            BattleSpirit? spirit = GetSpiritGridSelection();

            if (spirit == null)
                return;

            List_Teams.Text = spirit.Team.Name;

            List_Enemy.SelectedItem = spirit.BaseName;
            List_EnemyVariant.SelectedItem = spirit.VariantName;
            
            Input_NpcParamID.Value = spirit.BaseNpcID;
            Input_NpcThinkID.Value = spirit.BaseThinkID;

            List_StatScaling.Text = ((StatScalingEnum)spirit.Sp_StatScaling).ToString();

            Input_EnemyHpMult.Value = (decimal)spirit.HpMult;
            Input_EnemyDamageMult.Value = (decimal)spirit.DamageMult;

            SummonPosition_X.Value = (decimal)spirit.Position.X;
            SummonPosition_Z.Value = (decimal)spirit.Position.Z;
            SummonPosition_Angle.Value = (decimal)spirit.Position.Ang;
            
        }

        private SummonPos CreateSummonPosition()
        {
            if (!SummonPosition_Auto.Checked)
                return new SummonPos(SummonPosition_X.Value, SummonPosition_Z.Value, SummonPosition_Angle.Value);

            // TODO: auto dist logic
            decimal mag = SummonPosition_Auto_DistMagnitude.Value;
            SummonPos pos = new();

            /*
            float xOffset = 0;
            float buddyWidth = (float)newNpcRow["chrHitRadius"].Value;// * (float).75;
            if (isMultiSummon)
            {
                float xOffsetIncrement = buddyWidth;

                //this part doesn't actually make sense, but whatever.
                xOffset = (float)buddyParam.Rows[i - 1]["x_offset"].Value;
                if (xOffset >= 0)
                    xOffset += xOffsetIncrement; //increment
                else
                    xOffset -= xOffsetIncrement; //decrement
                xOffset *= -1; //invert

            }
            buddyParamRow["x_offset"].Value = xOffset; //horizontal offset 1
            buddyParamRow["z_offset"].Value = buddyWidth * -1; //horizontal offset 2
            */

            return pos;
        }

        private BattleSpirit CreateBattleSpiritFromElements()
        {
            BattleSpirit spirit = new()
            {
                BaseName = List_Enemy.Text,
                VariantName = List_EnemyVariant.Text,
                Team = teamDict[List_Teams.Text],
                Sp_StatScaling = (int)Enum.Parse(typeof(StatScalingEnum), List_StatScaling.Text),
                Position = CreateSummonPosition(),
                HpMult = (float)Input_EnemyHpMult.Value,
                DamageMult = (float)Input_EnemyDamageMult.Value,
                BaseNpcID = (int)Input_NpcParamID.Value,
                BaseThinkID = (int)Input_NpcThinkID.Value,
            };
            return spirit;
        }

        private void AddSpiritToGrid()
        {
            var spirit = CreateBattleSpiritFromElements();
            battleSpiritList.Add(spirit);
            UpdateSpiritGrid();
        }

        private BattleSpirit? GetSpiritGridSelection()
        {
            if (SpiritDataGrid.SelectedRows.Count == 0)
                return null;

            DataGridViewRow row = SpiritDataGrid.SelectedRows[0];
            return (BattleSpirit)row.Cells[0].Value;
        }

        private void SetSpiritGridSelection(BattleSpirit newSpirit)
        {
            if (SpiritDataGrid.SelectedRows.Count == 0)
                return;

            BattleSpirit oldSpirit = (BattleSpirit)SpiritDataGrid.SelectedRows[0].Cells[0].Value;
            battleSpiritList[battleSpiritList.IndexOf(oldSpirit)] = newSpirit;
        }

        private void UpdateSpiritGrid()
        {
            int prevIndex = 0;
            if (SpiritDataGrid.SelectedRows.Count > 0)
                prevIndex = SpiritDataGrid.SelectedRows[0].Index;
            SpiritDataGrid.DataSource = battleSpiritList.Select(spirit => new
            {
                spirit,
                spirit.Team.Name,
                spirit.VariantName,
                StatScaling = Enum.GetName(typeof(StatScalingEnum), spirit.Sp_StatScaling)
            }).ToList();
            SpiritDataGrid.Columns[0].Visible = false;
            SpiritDataGrid.Columns[1].HeaderCell.Value = "Team";
            SpiritDataGrid.Columns[2].HeaderCell.Value = "Enemy";
            SpiritDataGrid.Columns[2].Width = 150;
            SpiritDataGrid.Columns[3].HeaderCell.Value = "Scaling";
            // TODO: display individual scaling
            // TODO: maybe also dispay overall scaling by pre-multiplying stat scaling level + individual scaling?

            SpiritDataGrid.ClearSelection();
            if (prevIndex > SpiritDataGrid.Rows.Count - 1)
                prevIndex = SpiritDataGrid.Rows.Count - 1;
            if (prevIndex > -1)
                SpiritDataGrid.Rows[prevIndex].Selected = true;
        }

        private SpiritTeam CreateSpiritTeam()
        {
            SpiritTeam team = new()
            {
                Name = Input_TeamName.Text,
                PhantomShaderID = (int)Enum.Parse(typeof(PhantomEnum), List_TeamPhantomColor.Text),
                TeamType = (byte)Enum.Parse(typeof(TeamTypeEnum), List_TeamType.Text)
            };
            return team;
        }

        private void UpdateSelectedSpirit()
        {
            // Get data from selected spirit in summon grid and transfer it to UI elements.
            if (SpiritDataGrid.SelectedRows.Count == 0)
                return;

            var spirit = CreateBattleSpiritFromElements();
            SetSpiritGridSelection(spirit);
            UpdateSpiritGrid();
        }

    }
}