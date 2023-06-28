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
-- medium priority
    Options to randomize an entire ash
    Custom phantom colors
    Increase position preset increment based on enemy's hitbox size
        Would have to load regulation.bin early if i used this for preview. Maybe it should just be a execute-only thing for now?
-- low priority
    True summon-anywhere
        Edit super-overworld MSB and insert a summon thing into it.
            Doesn't appear to work. Looks like talkESD has some actual distance limit not affected by params?
        Requires making tool handle mod directory structures and whether or not user unpacked.
    Can probably allow editing team position even with presets active
        Add step increment to UI.
    Put phantom param stuff into a resource file, make it detail more info
    Replace team enum with more comprehensive info, so user knows where these scaling levels correspond
    Figure out how mimic tear works so it can be implemented
        Moving buddyParam entries to another ash DID NOT WORK
            So, probably some field in summon good/spEffect notifier, or hardcoded ID reference for good/spEffect/buddy.
    Change targeted ash name's FMG name
        Format: "Spirit Battler: [team] vs [team]
    Better catalog team behavior
        Maybe a custom class with a helpful label/info?
    Grid sorting (by team)
    Grid coloring (by team)
    Allow grid column resizing (currently resets on grid reload)
    Enemy names appear above their heads
        invader blaidd style. need to experiment with limitations. does it work with every team, or just enemies?
        Requires FMG modification which I'd like to avoid
*/

namespace EldenRingSpiritBattler
{
    public partial class MainForm
    {

        public string backupFileName = "";

        public Dictionary<string, int> spiritAshesDict = new();
        public List<string> spiritAshesCache = new();

        public Dictionary<string, SpiritTeam> teamDict = new();
        public Dictionary<string, List<Enemy>> enemyVariantDict = new();
        public List<string> enemyListCache = new();

        public List<BattleSpirit> battleSpiritList = new();

        public static UserConfig Config = new();

        public int GetRandomUnusedPhantomId()
        {
            Random rand = new();
            var enums = Enum.GetValues<PhantomEnum>().ToList().FindAll(e => !e.ToString().ToLower().Contains("invisible"));
            int phantomID;
            do
            {
                phantomID = (int)enums[rand.Next(0, enums.Count - 1)];
            } 
            while (teamDict.Values.ToList().Find(e => phantomID == e.PhantomParamID) != null);
            return phantomID;
        }

        public string[] GetOrderedEnumNames(Type enumType)
        {
            // Order by enum value
            return Enum.GetNames(enumType).OrderBy(e => Enum.Parse(enumType, e)).ToArray();
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
            return count * 8;
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
            int lineNum = 0;
            try
            {
                var file = File.ReadAllLines($@"{AppDomain.CurrentDomain.BaseDirectory}\Resources\EnemyInfoResource.txt");

                string variantKey = "";
                for (; lineNum < file.Length; lineNum++)
                {
                    var line = file[lineNum];
                    if (line.StartsWith("--"))
                    {
                        // Start of a new enemy section
                        variantKey = line[2..]; // Choose key name based on current line post-comment.
                        enemyVariantDict[variantKey] = new List<Enemy>();
                        continue;
                    }
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    var split = line.Split("||");
                    List<int> behaviorSpEffects = new();
                    if (split.Length == 5)
                    {
                        var effectSplit = split[4].Split(",");
                        foreach (var effect in effectSplit)
                        {
                            int effectID = int.Parse(effect);
                            if (effectID > 0)
                            {
                                behaviorSpEffects.Add(effectID);
                            }
                        }
                    }
                    Enemy newEnemy = new(split[0], int.Parse(split[1]), int.Parse(split[2]), int.Parse(split[3]), behaviorSpEffects);
                    enemyVariantDict[variantKey].Add(newEnemy);
                }
                foreach (var dict in enemyVariantDict.ToList())
                {
                    // Remove empty keys
                    if (!dict.Value.Any())
                    {
                        enemyVariantDict.Remove(dict.Key);
                        continue;
                    }
                    enemyVariantDict[dict.Key] = enemyVariantDict[dict.Key].DistinctBy(e => e.Name).ToList();
                }

                enemyListCache = enemyVariantDict.Keys.ToList();
                List_Enemy.DataSource = enemyListCache;
            }
            catch (Exception e)
            {
                throw new Exception($"Error loading \"Resources\\EnemyInfoResource.txt\" on line {lineNum}", e);
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
                spiritAshesCache = spiritAshesDict.Keys.ToList();
                List_SpiritAsh.DataSource = spiritAshesCache;
            }
            catch (Exception e)
            {
                throw new Exception("Error loading \"Resources\\EnemyInfoResource.txt\"", e);
            }
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

        private static PARAM.Row InsertParamRow(PARAM param, PARAM.Row row, int newID, int index = -1)
        {
            PARAM.Row newRow = new PARAM.Row(newID, "SpiritBattler " + newID, param.AppliedParamdef);

            for (var i = 0; i < row.Cells.Count; i++)
            {
                newRow.Cells[i].Value = row.Cells[i].Value;
            }
            if (index == -1)
                param.Rows.Insert(param.Rows.IndexOf(row) + 1, newRow);
            else
                param.Rows.Insert(index, newRow);

            return newRow;
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
            string regulationPath = FileDialog_Regulation.FileName;

            UpdateConsole("Checking Backup");
            if (!File.Exists(backupFileName))
            {
                // No backup file exists
                UpdateConsole("Creating Backup");
                File.Copy(FileDialog_Regulation.FileName, backupFileName);
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
            PARAM stoneParam;
            PARAM npcParam;
            PARAM npcThinkParam;
            PARAM goodsParam;
            PARAM spEffectParam;
            PARAM vfxParam;
            PARAM roleParam;
            try
            {
                buddyParam = paramList["BuddyParam"];
                stoneParam = paramList["BuddyStoneParam"];
                npcParam = paramList["NpcParam"];
                npcThinkParam = paramList["NpcThinkParam"];
                goodsParam = paramList["EquipParamGoods"];
                spEffectParam = paramList["SpEffectParam"];
                vfxParam = paramList["SpEffectVfxParam"];
                roleParam = paramList["RoleParam"];

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
            int buddyRowIndex = buddyParam.Rows.IndexOf(targetBuddyRow);

            foreach (var buddyRow in buddyParam.Rows.ToList())
            {
                // Clean targeted Spirit Ash
                if (Math.Abs(selectedBuddyRowID - buddyRow.ID) > 99)
                {
                    // This is not related to the targeted row
                    continue;
                }
                buddyParam.Rows.Remove(buddyRow);
            }

            for (var i = 0; i < battleSpiritList.Count; i++)
            {
                BattleSpirit spirit = battleSpiritList[i];
                SpiritTeam team = spirit.Team;
                //
                #region VfxParam
                PARAM.Row? newVfxRow = null;
                if (spirit.Team.PhantomParamID > 0
                    && enemyPhantomBlacklist.Contains(spirit.BaseNpcID - (spirit.BaseNpcID % 10000)) == false)
                {
                    int baseVfxID = 57000;
                    int newVfxID = 60000;
                    do
                    {
                        newVfxID++;
                    }
                    while (vfxParam[newVfxID] != null);
                    newVfxRow = InsertParamRow(vfxParam, vfxParam[baseVfxID], newVfxID);
                    newVfxRow["phantomParamOverwriteId"].Value = spirit.Team.PhantomParamID;
                }
                #endregion
                //

                //
                #region SpEffectParam
                int baseEffectID = 290000;
                int newEffectID = 291000;
                do
                {
                    newEffectID++;
                }
                while (spEffectParam[newEffectID] != null);
                PARAM.Row newSpEffectRow = InsertParamRow(spEffectParam, spEffectParam[baseEffectID], newEffectID);
                newSpEffectRow.Name = $"Spirit Battler VFX and Scaling - ({spirit.VariantName})";
                float hpMult = (float)spirit.HpMult * (float)spirit.Team.TeamHpMult;
                float damMult = (float)spirit.DamageMult * (float)spirit.Team.TeamDamageMult;

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
                if (newVfxRow != null)
                    newSpEffectRow["vfxId"].Value = newVfxRow.ID;
                spirit.Sp_SpecialScaling = newSpEffectRow.ID;
                #endregion
                //

                //
                #region NpcParam
                int npcID = spirit.BaseNpcID;
                int newNpcID = 100000000 + npcID;
                if (npcParam[npcID] == null)
                {
                    MessageBox.Show($"Summon {spirit.VariantName}'s base NpcParamID {npcID} cannot be found. Please fix this enemy.", "Error");
                    return false;
                }
                do
                {
                    newNpcID++;
                }
                while (npcParam[newNpcID] != null);
                PARAM.Row newNpcRow = InsertParamRow(npcParam, npcParam[npcID], newNpcID);

                newNpcRow["teamType"].Value = spirit.Team.TeamType;
                newNpcRow["itemLotId_enemy"].Value = -1;
                newNpcRow["itemLotId_map"].Value = -1;
                newNpcRow["GameClearSpEffectID"].Value = -1;
                newNpcRow["getSoul"].Value = (uint)0;
                newNpcRow["npcType"].Value = (byte)0;
                newNpcRow["phantomShaderId"].Value = -1; // Overrides VFX phantom. Only used by Melina in vanilla.

                if (Config.ReduceEnemyCollisionRadii)
                {
                    // Cap map hit radii to prevent spawning issues
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

                // NpcParam Special Effects
                var buddyEffects = spirit.SpecialEffects;
                int iBuddy = 0;
                for (var iEffect = 0; iEffect <= 31; iEffect++)
                {
                    int effectID = (int)newNpcRow["spEffectID" + iEffect].Value;
                    if (spirit.Sp_StatScaling != (int)StatScalingEnum.Default)
                    {
                        // Strip out vanilla stat scaling effects
                        if ((effectID >= ScalingEffectBaseId && effectID <= ScalingEffectMaxId)
                            || (effectID >= c0000ScalingEffectBaseId && effectID <= c0000ScalingEffectMaxId))
                        {
                            // Vanilla scaling spEffect. Remove it.
                            newNpcRow["spEffectID" + iEffect].Value = 0;
                        }
                    }
                    if (effectID <= 0 && iBuddy < buddyEffects.Count)
                    {
                        // Slot is empty, insert effect
                        newNpcRow["spEffectID" + iEffect].Value = buddyEffects[iBuddy];
                        iBuddy++;
                    }
                }
                if (iBuddy < buddyEffects.Count)
                {
                    MessageBox.Show($"Not enough free SpEffect slots in NpcParam ID {spirit.BaseNpcID}.\nPlease report this issue and ID, along with any other mods you have installed.", "Error", MessageBoxButtons.OK);
                    return false;
                }
                #endregion
                //

                //
                #region NpcThinkParam
                int npcThinkID = spirit.BaseThinkID;
                int newNpcThinkID = 100000000 + npcThinkID;
                if (npcThinkParam[npcThinkID] == null)
                {
                    MessageBox.Show($"Summon {spirit.VariantName}'s base NpcThinkParam ID {npcThinkID} cannot be found. Please fix your EnemyInfoResource file if it has been modified.", "Error");
                    return false;
                }
                do
                {
                    newNpcThinkID++;
                }
                while (npcThinkParam[newNpcThinkID] != null);
                PARAM.Row newNpcThinkRow = InsertParamRow(npcThinkParam, npcThinkParam[npcThinkID], newNpcThinkID);

                newNpcThinkRow["isBuddyAI"].Value = true; // This PROBABLY overrides backhomeDist, etc.
                newNpcThinkRow["backhomeDist"].Value = (UInt16)9999;
                newNpcThinkRow["maxBackhomeDist"].Value = (UInt16)9999;
                newNpcThinkRow["backhomeBattleDist"].Value = (UInt16)999;
                if (Config.SummonsFindTargetsEasily)
                {
                    // Find targets easily
                    newNpcThinkRow["nose_dist"].Value = (UInt16)30;
                    newNpcThinkRow["SoundTargetForgetTime"].Value = (float)9999.0f;
                    newNpcThinkRow["SightTargetForgetTime"].Value = (float)9999.0f;
                    newNpcThinkRow["MemoryTargetForgetTime"].Value = (float)99.0f;
                }
                else
                {
                    // Don't find targets easily
                    newNpcThinkRow["nose_dist"].Value = (UInt16)0;
                    newNpcThinkRow["SoundTargetForgetTime"].Value = (float)15.0f;
                    newNpcThinkRow["SightTargetForgetTime"].Value = (float)0.1f;
                    newNpcThinkRow["MemoryTargetForgetTime"].Value = (float)0.5f;
                    if (spirit.LongDistanceAggro)
                    {
                        // Notice targets at distance
                        newNpcThinkRow["eye_dist"].Value = (UInt16)30;
                        newNpcThinkRow["BattleStartDist"].Value = (UInt16)20;
                    }
                    else
                    {
                        // Do not notice targets at distance
                        newNpcThinkRow["eye_dist"].Value = (UInt16)2;
                        newNpcThinkRow["BattleStartDist"].Value = (UInt16)2;
                    }
                }
                #endregion
                //

                //
                #region BuddyParam (individual)
                PARAM.Row buddyParamRow = InsertParamRow(buddyParam, targetBuddyRow, targetBuddyRow.ID + i, buddyRowIndex + i);

                buddyParamRow["npcParamId"].Value = newNpcRow.ID;
                buddyParamRow["npcThinkParamId"].Value = newNpcThinkRow.ID;
                buddyParamRow["npcPlayerInitParamId"].Value = spirit.CharaInitID; // CharaInit

                buddyParamRow["appearOnAroundSekihi"].Value = (byte)0; // 0 = Summon using player location.
                if (spirit.FollowPlayer)
                {
                    buddyParamRow["disablePCTargetShare"].Value = false; // Must be true for enemies, or else they can try to target themselves.
                    buddyParamRow["pcFollowType"].Value = (byte)0; // 0 = Follow player around, 1 = Wander Around, 2 = Wait in place?
                }
                else
                {
                    buddyParamRow["disablePCTargetShare"].Value = true; // Must be true for enemies, or else they can try to target themselves.
                    buddyParamRow["pcFollowType"].Value = (byte)1; // 0 = Follow player around, 1 = Wander Around, 2 = Wait in place?
                }

                if (spirit.Sp_StatScaling == (int)StatScalingEnum.Spirit)
                {
                    // Spirit stats will increase with ash reinforcement
                    int dopingEffectID;
                    if (spirit.Is_c0000)
                    {
                        dopingEffectID = BuddyDopingSpEffect_c0000;
                    }
                    else
                    {
                        dopingEffectID = BuddyDopingSpEffect;
                    }
                    for (var ii = 0; ii <= 10; ii++)
                    {
                        buddyParamRow["dopingSpEffect_lv" + ii].Value = dopingEffectID + ii;
                    }
                }
                else
                {
                    // Spirit stats will not increase with ash reinforcement
                    for (var ii = 0; ii <= 10; ii++)
                    {
                        buddyParamRow["dopingSpEffect_lv" + ii].Value = -1;
                    }
                }
                buddyParamRow["npcParamId_ridden"].Value = -1;
                buddyParamRow["npcThinkParamId_ridden"].Value = -1;
                buddyParamRow["generateAnimId"].Value = -1;

                //Position
                SummonPos pos = GetOffsetSpiritSummonPos(spirit);
                buddyParamRow["x_offset"].Value = pos.X; // Horizontal offset 1
                buddyParamRow["z_offset"].Value = pos.Z; // Horizontal offset 2
                buddyParamRow["y_angle"].Value = pos.Ang;
                #endregion
                //
            }
            //
            #region GoodsParam
            if (Option_SpiritAshNoRequirements.Checked)
            {
                int buddyTriggerSpEffect = (int)targetBuddyRow["triggerSpEffectId"].Value;
                for(var i = 0; i < goodsParam.Rows.Count; i++)
                {
                    PARAM.Row goodsRow = goodsParam.Rows[i];

                    if (Option_TargetAllSpiritAshes.Checked
                        && goodsRow.ID >= 200000 && goodsRow.ID < 270000)
                    {                        
                        goodsRow["consumeHP"].Value = (Int16)0;
                        goodsRow["consumeMP"].Value = (Int16)0;
                    }
                    else if (buddyTriggerSpEffect == (int)goodsRow["refId_default"].Value)
                    {
                        // This is the targeted spirit ash good
                        for (int i2 = 0; i2 <= 10; i2++)
                        {
                            // Reinforced goods
                            goodsParam.Rows[i+i2]["consumeHP"].Value = (Int16)0;
                            goodsParam.Rows[i+i2]["consumeMP"].Value = (Int16)0;
                        }
                    }
                }
            }
            #endregion
            //
            //
            #region BuddyStoneParam
            foreach (var row in stoneParam.Rows.ToList())
            {
                if (Config.ExpandSummonAreas)
                {
                    row["activateRange"].Value = ushort.MaxValue;
                    row["overwriteReturnRange"].Value = (short)-1;
                    row["overwriteActivateRegionEntityId"].Value = (uint)0;
                    row["warnRegionEntityId"].Value = (uint)0;
                }
                if (Config.EnableResummoning)
                {
                    row["summonedEventFlagId"].Value = (uint)0;
                    row["eliminateTargetEntityId"].Value = (uint)0;
                }
            }
            #endregion
            //
            //
            #region RoleParam
            PARAM.Row playerRole = roleParam[0];
            if (Option_HidePlayer.Checked)
            {
                playerRole["teamType"].Value = TeamTypeEnum.WanderingGhost;
                playerRole["phantomParamId"].Value = PhantomEnum.Invisible;
            }
            else
            {
                playerRole["teamType"].Value = TeamTypeEnum.Player;
                playerRole["phantomParamId"].Value = PhantomEnum.None;
            }
            #endregion
            //
            UpdateConsole("Exporting Params");

            //output regulation
            foreach (BinderFile file in paramBND.Files)
            {
                string name = Path.GetFileNameWithoutExtension(file.Name);
                if (paramList.ContainsKey(name))
                    file.Bytes = paramList[name].Write();
            }

            SFUtil.EncryptERRegulation(regulationPath, paramBND); // Save regulation.bin

            return true;
        }

        public void UpdateConsole(string text)
        {
            t_console.Text = text;
            Application.DoEvents();
        }

        private void Restore_Regulation()
        {
            string regulationPath = FileDialog_Regulation.FileName;

            FileSystem.DeleteFile(regulationPath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
            if (!File.Exists(backupFileName))
            {
                MessageBox.Show($"Failed to restore backup as \"{backupFileName}\" could not be found.", "Error", MessageBoxButtons.OK);
                UpdateConsole("Backup Restoration Failed");
                b_restoreRegulation.Enabled = false;
            }
            else
            {
                File.Move(backupFileName, regulationPath, false);
                UpdateConsole("Backup Restored");
                b_restoreRegulation.Enabled = false;
            }
        }

        // SpiritTeam functions
        #region Team
        private SpiritTeam GetSelectedTeamFromGrid()
        {
            DataGridViewRow row = TeamDataGrid.SelectedRows[0];
            return (SpiritTeam)row.Cells[0].Value;
        }
        private void UpdateTeamGridAndList(int scrollIndexOffset = 0)
        {
            int prevIndex = 0;
            if (TeamDataGrid.SelectedRows.Count > 0)
                prevIndex = TeamDataGrid.SelectedRows[0].Index;

            int prevScrollIndex = TeamDataGrid.FirstDisplayedScrollingRowIndex + scrollIndexOffset;
            if (prevScrollIndex < 0)
                prevScrollIndex = 0;
            else if (prevScrollIndex >= TeamDataGrid.Rows.Count)
                prevScrollIndex = TeamDataGrid.Rows.Count - 1;

            TeamDataGrid.DataSource = teamDict.Select(team => new
            {
                team.Value,
                team.Value.Name,
                V1 = Enum.GetName(typeof(TeamTypeEnum), team.Value.TeamType),
                V2 = Enum.GetName(typeof(PhantomEnum), team.Value.PhantomParamID),
                Scale = GetTeamScalingLevelString(team.Value),
                Pos = GetTeamPositionString(team.Value),
                Follow = team.Value.FollowPlayer
            }).ToList();
            TeamDataGrid.Columns[0].Visible = false;
            TeamDataGrid.Columns[1].HeaderCell.Value = "Name";
            TeamDataGrid.Columns[1].Width = 150;
            TeamDataGrid.Columns[2].HeaderCell.Value = "Team Type";
            TeamDataGrid.Columns[2].Width = 90;
            TeamDataGrid.Columns[3].HeaderCell.Value = "Color";
            TeamDataGrid.Columns[3].Width = 130;
            TeamDataGrid.Columns[4].HeaderCell.Value = "Stats";
            TeamDataGrid.Columns[4].Width = 60;
            TeamDataGrid.Columns[5].HeaderCell.Value = "Position";
            TeamDataGrid.Columns[5].Width = 85;
            TeamDataGrid.Columns[6].HeaderCell.Value = "Follow";
            TeamDataGrid.Columns[6].Width = 50;

            if (prevIndex > TeamDataGrid.Rows.Count - 1)
                prevIndex = TeamDataGrid.Rows.Count - 1;
            if (prevIndex > -1)
                TeamDataGrid.Rows[prevIndex].Selected = true;

            if (prevScrollIndex != -1)
                TeamDataGrid.FirstDisplayedScrollingRowIndex = prevScrollIndex; // Scroll to selection

            // Update enemy chosen team list and retain spirit's chosen team index
            int prevChosenTeamIndex = List_EnemyChosenTeam.SelectedIndex;
            List_EnemyChosenTeam.DataSource = teamDict.Select(team => team.Key).ToList(); // Also triggers UpdateSelectedSpirit();

            if (prevChosenTeamIndex != -1)
                List_EnemyChosenTeam.SelectedIndex = prevChosenTeamIndex;
            else
                List_EnemyChosenTeam.SelectedIndex = 0;

        }

        private SpiritTeam CreateTeamFromElements()
        {
            SummonPos? teamPos = teamSummonPresetDict[List_TeamSummonPreset.Text];
            teamPos ??= new SummonPos(Input_TeamSummonPos_X.Value, Input_TeamSummonPos_Z.Value, Input_TeamSummonPos_Ang.Value);

            SpiritTeam team = new()
            {
                Name = Input_TeamName.Text,
                PhantomParamID = (int)Enum.Parse(typeof(PhantomEnum), List_TeamPhantomColor.Text),
                TeamType = (byte)Enum.Parse(typeof(TeamTypeEnum), List_TeamType.Text),
                TeamHpMult = Input_TeamHpMult.Value,
                TeamDamageMult = Input_TeamDamageMult.Value,
                FollowPlayer = Option_TeamFollowPlayer.Checked,
                TeamPosition = teamPos,
            };
            return team;
        }

        private void UpdateSelectedTeam(SpiritTeam team)
        {
            var currentRow = TeamDataGrid.SelectedRows[0];
            var oldTeamKey = (string)currentRow.Cells[1].Value;

            if (teamDict.TryGetValue(oldTeamKey, out SpiritTeam? oldteam))
            {
                // Update refs to this team from spirits
                foreach (BattleSpirit spirit in battleSpiritList)
                {
                    if (spirit.Team == oldteam)
                        spirit.Team = team;
                }
            }
            else
            {
                throw new Exception("Couldn't locate old teamDict key while trying to update team data.");
            }
            // Name may have been changed, so swap out keys in teamDict.
            teamDict.Remove(oldTeamKey); // Remove old key
            teamDict[team.Name] = team; // Add new key
            UpdateTeamGridAndList();
        }

        private void AddTeamToGrid(SpiritTeam team)
        {
            teamDict[team.Name] = team;
            UpdateTeamGridAndList();
        }

        private SpiritTeam AddRandomizedTeamToGrid(TeamTypeEnum teamType, SummonPos? summonPos = null)
        {
            string teamName = GetRandomUnusedTeamName();
            SpiritTeam team = new(teamName, GetRandomUnusedPhantomId(), (byte)teamType, false, summonPos);
            teamDict.Add(teamName, team);
            return team;
        }

        public void SetRandomTeamName()
        {
            Input_TeamName.Text = GetRandomUnusedTeamName();
            SetSelectedTeamName();
        }
        public void SetSelectedTeamName()
        {
            if (teamDict.ContainsKey(Input_TeamName.Text))
            {
                MessageBox.Show($"Cannot name team \"{Input_TeamName.Text}\", there is already a team with that name.", "Error", MessageBoxButtons.OK);
                Input_TeamName.Text = (string)TeamDataGrid.SelectedRows[0].Cells[1].Value; // Reset to name stored in grid
            }
            else
            {
                UpdateSelectedTeam(new(), new());
            }
        }

        public string GetRandomUnusedTeamName()
        {
            Random rand = new();
            if (rand.Next(1, 42069) == 1)
            {
                return "Prod's Feet Enjoyers";
            }
            else
            {
                if (teamDict.Count >= randomTeamNames.Length)
                    return rand.Next(0, int.MaxValue).ToString(); // Meme, but also this can't happen atm since randomTeamNames is longer than buddy limit.

                string name;
                do
                {
                    name = randomTeamNames[rand.Next(0, randomTeamNames.Length)];
                }
                while (teamDict.ContainsKey(name));
                return name;
            }
        }

        public bool _noUpdateTeam = false;
        public void UpdateTeamElements()
        {
            _noUpdateTeam = true;
            SpiritTeam team = GetSelectedTeamFromGrid();

            List_TeamSummonPreset.Text = team.TeamPosition.Label;

            Input_TeamName.Text = team.Name;
            Input_TeamDamageMult.Value = team.TeamDamageMult;
            Input_TeamHpMult.Value = team.TeamHpMult;
            List_TeamPhantomColor.Text = ((PhantomEnum)team.PhantomParamID).ToString();
            Input_TeamSummonPos_X.Value = (decimal)team.TeamPosition.X;
            Input_TeamSummonPos_Z.Value = (decimal)team.TeamPosition.Z;
            Input_TeamSummonPos_Ang.Value = (decimal)team.TeamPosition.Ang;
            Option_TeamFollowPlayer.Checked = team.FollowPlayer;
            List_TeamType.Text = ((TeamTypeEnum)team.TeamType).ToString();
            _noUpdateTeam = false;
        }
        #endregion
        //

        // BattleSpirit functions
        #region Spirits
        public void AddRandomSpiritToGrid()
        {;
            preventEnemyEdited = true;
            int prevIndex = -1;
            if (SpiritDataGrid.SelectedRows.Count > 0)
                prevIndex = SpiritDataGrid.SelectedRows[0].Index;

            SelectRandomSpiritAndSetToElements();
            BattleSpirit spirit = CreateSpiritFromElements();
            bool success = InsertSpiritToList(spirit, battleSpiritList.IndexOf(GetSpiritGridSelection()!) + 1);
            if (success)
            {
                SpiritDataGrid.ClearSelection();
                SpiritDataGrid.Rows[prevIndex + 1].Selected = true;
            }

            preventEnemyEdited = false;
        }

        public void SelectRandomSpiritAndSetToElements()
        {
            Search_Enemy.Text = "";
            Random rand = new();
            List_Enemy.SelectedIndex = rand.Next(0, List_Enemy.Items.Count - 1);
            List_EnemyVariant.SelectedIndex = rand.Next(0, List_EnemyVariant.Items.Count - 1);
        }

        private void UpdateSpiritElements()
        {
            BattleSpirit? spirit = GetSpiritGridSelection();

            if (spirit == null)
                return;
            /*
            // Make team grid select this spirit's team
            TeamDataGrid.ClearSelection();
            foreach (DataGridViewRow row in TeamDataGrid.Rows)
            {
                SpiritTeam team = (SpiritTeam)row.Cells[0].Value;
                if (team.Name == spirit.Team.Name)
                {
                    row.Selected = true;
                    break;
                }
            }
            if (TeamDataGrid.SelectedRows.Count == 0)
                throw new Exception("Couldn't find selected Spirit's team in TeamDataGrid.");
            */
            List_Enemy.SelectedItem = spirit.BaseName;
            List_EnemyVariant.SelectedItem = spirit.VariantName;

            Input_NpcParamID.Value = spirit.BaseNpcID;
            Input_NpcThinkID.Value = spirit.BaseThinkID;
            Input_CharaInitID.Value = spirit.CharaInitID;

            List_EnemyBehaviorSpEffects.DataSource = spirit.BehaviorSpEffects;

            List_StatScaling.Text = ((StatScalingEnum)spirit.Sp_StatScaling).ToString();

            Input_EnemyHpMult.Value = spirit.HpMult;
            Input_EnemyDamageMult.Value = spirit.DamageMult;

            List_EnemyChosenTeam.SelectedItem = spirit.Team.Name;

            SummonPosition_X.Value = (decimal)spirit.Position.X;
            SummonPosition_Z.Value = (decimal)spirit.Position.Z;
            SummonPosition_Angle.Value = (decimal)spirit.Position.Ang;

            Option_Spirit_SearchesLongRange.Checked = spirit.LongDistanceAggro;

            //UpdateTeamElements();
        }

        private void UpdateSelectedSpirit()
        {
            // EnemyWasUpdated
            // Get data from selected spirit in summon grid and transfer it to UI elements.
            if (SpiritDataGrid.SelectedRows.Count == 0)
                return;

            var spirit = CreateSpiritFromElements();
            SetSpiritGridSelection(spirit);
            UpdateSpiritGrid();
        }

        private void DeleteSelectedSpiritFromGrid()
        {
            if (SpiritDataGrid.Rows.Count <= 1)
            {
                // Don't let number of rows drop below 1
                return;
            }
            battleSpiritList.Remove(GetSpiritGridSelection()!);

            UpdateSpiritGrid(-1);
            UpdateSpiritElements();
            Search_Enemy.Text = "";
        }

        private void SetSpiritGridSelection(BattleSpirit newSpirit)
        {
            if (SpiritDataGrid.SelectedRows.Count == 0)
                return;

            BattleSpirit oldSpirit = (BattleSpirit)SpiritDataGrid.SelectedRows[0].Cells[0].Value;
            battleSpiritList[battleSpiritList.IndexOf(oldSpirit)] = newSpirit;
        }

        private string GetStatScalingLevelString(BattleSpirit spirit)
        {
            string enemyScalingLvl = $"{Enum.GetName(typeof(StatScalingEnum), spirit.Sp_StatScaling)}";
            decimal hp = spirit.HpMult * spirit.Team.TeamHpMult;
            decimal dam = spirit.DamageMult * spirit.Team.TeamDamageMult;

            return $"{enemyScalingLvl}, *{hp} *{dam}";
        }
        private string GetTeamScalingLevelString(SpiritTeam team)
        {
            decimal hp = team.TeamHpMult;
            decimal dam = team.TeamDamageMult;
            return $"*{hp} *{dam}";
        }
        private string GetTeamPositionString(SpiritTeam team)
        {
            return team.TeamPosition.Label;
        }
        private string GetFinalPositionString(BattleSpirit spirit)
        {
            SummonPos pos = GetOffsetSpiritSummonPos(spirit);

            return $"{pos.X}x {pos.Z}z {pos.Ang}º";
        }

        private void UpdateSpiritGrid(int scrollIndexOffset = 0)
        {
            int prevIndex = 0;
            if (SpiritDataGrid.SelectedRows.Count > 0)
                prevIndex = SpiritDataGrid.SelectedRows[0].Index;

            int prevScrollIndex = SpiritDataGrid.FirstDisplayedScrollingRowIndex + scrollIndexOffset;
            if (prevScrollIndex < 0)
                prevScrollIndex = 0;
            else if (prevScrollIndex >= SpiritDataGrid.Rows.Count)
                prevScrollIndex = SpiritDataGrid.Rows.Count - 1;

            SpiritDataGrid.DataSource = battleSpiritList.Select(spirit => new
            {
                spirit,
                spirit.Team.Name,
                spirit.VariantName,
                S = GetStatScalingLevelString(spirit),
                P = GetFinalPositionString(spirit),
                spirit.LongDistanceAggro
            }).ToList();
            SpiritDataGrid.Columns[0].Visible = false;
            SpiritDataGrid.Columns[1].HeaderCell.Value = "Team";
            SpiritDataGrid.Columns[1].Width = 150;
            SpiritDataGrid.Columns[2].HeaderCell.Value = "Enemy";
            SpiritDataGrid.Columns[2].Width = 200;
            SpiritDataGrid.Columns[3].HeaderCell.Value = "Stats";
            SpiritDataGrid.Columns[3].Width = 80;
            SpiritDataGrid.Columns[4].HeaderCell.Value = "Position";
            SpiritDataGrid.Columns[4].Width = 85;
            SpiritDataGrid.Columns[5].HeaderCell.Value = "Aggro";
            SpiritDataGrid.Columns[5].Width = 45;

            SpiritDataGrid.ClearSelection();
            if (prevIndex > SpiritDataGrid.Rows.Count - 1)
                prevIndex = SpiritDataGrid.Rows.Count - 1;
            if (prevIndex > -1)
                SpiritDataGrid.Rows[prevIndex].Selected = true;

            if (prevScrollIndex != -1)
                SpiritDataGrid.FirstDisplayedScrollingRowIndex = prevScrollIndex; // Scroll to selection
        }

        private SpiritTeam GetChosenTeamFromElement()
        {
            foreach (SpiritTeam team in teamDict.Values)
            {
                if (List_EnemyChosenTeam.Text == team.Name)
                {
                    return team;
                }
            }
            throw new Exception("Could not locate team from List_EnemyChosenTeam UI element.");
        }

        private BattleSpirit CreateSpiritFromElements()
        {
            BattleSpirit spirit = new()
            {
                BaseName = List_Enemy.Text,
                VariantName = List_EnemyVariant.Text,
                Team = GetChosenTeamFromElement(),
                Sp_StatScaling = (int)Enum.Parse(typeof(StatScalingEnum), List_StatScaling.Text),
                Position = CreateSpiritSummonPositionFromElements(),
                HpMult = Input_EnemyHpMult.Value,
                DamageMult = Input_EnemyDamageMult.Value,
                BaseNpcID = (int)Input_NpcParamID.Value,
                BaseThinkID = (int)Input_NpcThinkID.Value,
                CharaInitID = (int)Input_CharaInitID.Value,
                BehaviorSpEffects = List_EnemyBehaviorSpEffects.Items.Cast<int>().ToList(),
                LongDistanceAggro = Option_Spirit_SearchesLongRange.Checked
            };
            return spirit;
        }

        public bool AddSpiritToList(BattleSpirit spirit)
        {
            if (SpiritDataGrid.Rows.Count >= BuddyLimit)
            {
                MessageBox.Show($"A spirit ash cannot handle more than {BuddyLimit} summons at once. Sorry!", "Summon Limit");
                return false;
            }
            battleSpiritList.Add(spirit);
            UpdateSpiritGrid(1);
            return true;
        }
        public bool InsertSpiritToList(BattleSpirit spirit, int index)
        {
            if (SpiritDataGrid.Rows.Count >= BuddyLimit)
            {
                MessageBox.Show($"A spirit ash cannot handle more than {BuddyLimit} summons at once. Sorry!", "Summon Limit");
                return false;
            }
            battleSpiritList.Insert(index, spirit);
            UpdateSpiritGrid(1);
            return true;
        }

        private BattleSpirit? GetSpiritGridSelection()
        {
            if (SpiritDataGrid.SelectedRows.Count == 0)
                return null;

            DataGridViewRow row = SpiritDataGrid.SelectedRows[0];
            return (BattleSpirit)row.Cells[0].Value;
        }
        #endregion
        //


        /// <summary>
        /// Get a spirit's summon pos that includes position preset offsets.
        /// </summary>
        private SummonPos GetOffsetSpiritSummonPos(BattleSpirit spirit)
        {
            SpiritTeam team = spirit.Team;

            int totalCount = 0;
            int myCount = 0;
            foreach (BattleSpirit s in battleSpiritList)
            {
                if (s.Team.Name == team.Name)
                {
                    totalCount++;
                    if (s == spirit)
                    {
                        myCount = totalCount;
                    }
                }
            }
            if (totalCount == 0)
                throw new Exception("Found zero enemies with teams that matched the targeted team");

            float x_final = team.TeamPosition.X;
            float z_final = team.TeamPosition.Z;
            float ang = team.TeamPosition.Ang;
            x_final += spirit.Position.X;
            z_final += spirit.Position.Z;
            //ang += spirit.Position.Ang; // This needs math to work (UI element is disabled)

            if (team.TeamPosition.EnemiesOffsetInitX == true)
            {
                // Offset X coord based on total enemy count
                x_final -= (totalCount + 1) * team.TeamPosition.X_increment * 0.5f;
            }
            x_final += team.TeamPosition.X_increment * myCount;
            z_final += team.TeamPosition.Z_increment * myCount;

            return new SummonPos(x_final, z_final, ang);
        }

        private SummonPos CreateSpiritSummonPositionFromElements()
        {
            return new SummonPos(SummonPosition_X.Value, SummonPosition_Z.Value, SummonPosition_Angle.Value);
        }
    }
}