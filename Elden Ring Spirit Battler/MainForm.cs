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

        public List<(int, string)> spiritAshesList = new();
        //public Dictionary<string, Enemy> enemyDict = new();
        public Dictionary<string, List<Enemy>> enemyVariantDict = new();
        public List<BattleSpirit> battleSpiritList = new();
        public Dictionary<string, SpiritTeam> teamDict;

        public class Enemy
        {
            public string Name;
            public int NpcID;
            public int ThinkID;
            public Enemy(string name, int npcID, int thinkID)
            {
                Name = name;
                NpcID = npcID;
                ThinkID = thinkID;
            }
        }

        public class SummonPos
        {
            public float X;
            public float Z;
            public float Ang;
            public SummonPos() { }
            public SummonPos(float x, float z, float ang)
            {
                X = x;
                Z = z;
                Ang = ang;
            }
            public SummonPos(decimal x, decimal z, decimal ang)
            {
                X = (float)x;
                Z = (float)z;
                Ang = (float)ang;
            }
        }

        public class BattleSpirit
        {
            public string BaseName = "";
            public string VariantName = "";
            public int BaseNpcID;
            public int BaseThinkID;
            public SpiritTeam Team = null!;
            public SummonPos Position = new(); // X, Z, Angle

            public float HpMult;
            public float DamageMult;
            public int Sp_StatScaling;
            public int Sp_SpecialScaling;
            public List<int> SpecialEffects
            {
                get
                {
                    List<int> effects = new();
                    effects.Add(Sp_StatScaling);
                    if (Team.BonusStatScalingEffect > 0)
                        effects.Add(Team.BonusStatScalingEffect);
                    if (Sp_SpecialScaling > 0)
                        effects.Add(Sp_SpecialScaling);
                    return effects;
                }
            }
            public BattleSpirit()
            { }
        }

        public class SpiritTeam
        {
            public string Name = "";
            public int PhantomShaderID; // PhantomParam ID to put into NpcParam
            public byte TeamType; // NpcParam enum
            public int BonusStatScalingEffect; // Special Effect with bonus stat scaling
            public SpiritTeam()
            { }
            public SpiritTeam(string name, int phantomShaderID, int teamStatScaling, byte teamType)
            {
                Name = name;
                PhantomShaderID = phantomShaderID;
                BonusStatScalingEffect = teamStatScaling;
                TeamType = teamType;
            }
        }

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
        }

        public string[] GetOrderedEnumNames(Type enumType)
        {
            // Order by enum value
            return Enum.GetNames(enumType).OrderBy(e => Enum.Parse(enumType, e)).ToArray();
        }

        public class SearchFilterClass
        {
            public List<string> Results_Cache = new();
            public List<string> Results_Filtered = new();
            public string SearchFilter_Cache;
            public string SearchFilter;
            public SearchFilterClass() { }
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
                spiritAshesList.Clear();
                var file = File.ReadAllLines($@"{AppDomain.CurrentDomain.BaseDirectory}\Resources\SpiritAshResource.txt");

                foreach (var line in file)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;
                    if (line.StartsWith("--"))
                        continue;

                    var split = line.Split("||");
                    spiritAshesList.Add((int.Parse(split[0]), split[1]));
                }
                List_SpiritAsh.DataSource = spiritAshesList.Select(e => e.Item2).ToList();
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


        private bool CreateBuddy()
        {
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

            var selectedBuddyRowID = ((KeyValuePair<string, int>)List_SpiritAsh.SelectedItem).Value;
            PARAM.Row targetBuddyRow = buddyParam[selectedBuddyRowID];

            foreach (var buddyRow in buddyParam.Rows)
            {
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
                // TODO: insert rows for new individual scaling effects, then add them to spirit list
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

                /*
                UInt32 baseHP = (UInt32)newNpcRow["hp"].Value;
                float maxHPMod = (float)n_hpMult.Value;
                newNpcRow["hp"].Value = (UInt32)Math.Floor(baseHP * maxHPMod); //add onto existing multiplier
                */


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
                // Todo: organize scaling effect, and phantom param effect
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

        public void UpdateConsole(string text)
        {
            t_console.Text = text;
            Application.DoEvents();
        }

        private void b_randomize_Click(object sender, EventArgs e)
        {
            //start randomizer

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

            if (CreateBuddy())
            {
                // Success
                GC.Collect(); // Free memory
                UpdateConsole("Finished!");
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("All done!", "Finished", MessageBoxButtons.OK);
            }
            else
            {
                // Success
                GC.Collect(); // Free memory
                UpdateConsole("Could not finish");
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("Execution failed.", "Error", MessageBoxButtons.OK);
            }

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

        private void b_restoreRegulation_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete Regulation.bin and restore backup?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Restore_Regulation();
        }

        private void GetLoadedGridSpiritInfo()
        {
            BattleSpirit? spirit = GetSpiritGridSelection();

            if (spirit == null)
                return;

            //TODO: set elements from grid selection

            List_Enemy.SelectedItem = spirit.BaseName;
            List_EnemyVariant.SelectedItem = spirit.VariantName;

            SummonPosition_X.Value = (decimal)spirit.Position.X;
            SummonPosition_Z.Value = (decimal)spirit.Position.Z;
            SummonPosition_Angle.Value = (decimal)spirit.Position.Ang;
            
        }

        private void SpiritDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //GetLoadedGridSpiritInfo();
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
        }

        private void List_EnemyVariant_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update NpcParamId and NpcThinkParam elements
            Input_NpcParamID.Value = enemyVariantDict[List_Enemy.Text][List_EnemyVariant.SelectedIndex].NpcID;
            Input_NpcThinkID.Value = enemyVariantDict[List_Enemy.Text][List_EnemyVariant.SelectedIndex].ThinkID;
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

        private BattleSpirit CreateBattleSpirit()
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

        private void Button_AddSpiritToList_Click(object sender, EventArgs e)
        {
            var spirit = CreateBattleSpirit();
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

        private void SetSpiritGridSelection(BattleSpirit spirit)
        {
            if (SpiritDataGrid.SelectedRows.Count == 0)
                return;

            DataGridViewRow row = SpiritDataGrid.SelectedRows[0];
            row.Cells[0].Value = spirit;
        }

        private void UpdateSpiritGrid()
        {
            SpiritDataGrid.DataSource = battleSpiritList.Select(spirit => new { spirit, spirit.Team.Name, spirit.VariantName }).ToList();
            SpiritDataGrid.Columns[0].Visible = false;
            SpiritDataGrid.Columns[1].HeaderCell.Value = "Team";
            SpiritDataGrid.Columns[2].HeaderCell.Value = "Enemy";
        }
        private void Button_RemoveSpiritFromList_Click(object sender, EventArgs e)
        {
            if (SpiritDataGrid.SelectedRows.Count == 0)
                return;
            battleSpiritList.Remove(GetSpiritGridSelection());

            UpdateSpiritGrid();
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

        private void Button_AddNewTeam_Click(object sender, EventArgs e)
        {
            teamDict[Input_TeamName.Text] = CreateSpiritTeam();
            LoadTeamsResource();
        }

        private void Button_GetDataSelection_Click(object sender, EventArgs e)
        {
            GetLoadedGridSpiritInfo();
        }

        private void Button_SetDataSelection_Click(object sender, EventArgs e)
        {
            var spirit = CreateBattleSpirit();
            SetSpiritGridSelection(spirit);
            UpdateSpiritGrid();
        }

        private void Button_RandomTeamName_Click(object sender, EventArgs e)
        {
            SetRandomTeamName();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}