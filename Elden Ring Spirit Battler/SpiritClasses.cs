using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EldenRingSpiritBattler
{
    /// <summary>
    /// Object derived from .txt resource that contains a unique enemy's info.
    /// </summary>
    public class Enemy
    {
        public string Name;
        public int NpcID;
        public int ThinkID;
        public int CharaInitID;
        public List<int> BehaviorSpEffects;
        public Enemy(string name, int npcID, int thinkID, int charaInitID, List<int> behaviorSpEffects)
        {
            Name = name;
            NpcID = npcID;
            ThinkID = thinkID;
            CharaInitID = charaInitID;
            BehaviorSpEffects = behaviorSpEffects;
        }
    }

    /// <summary>
    /// Contains X/Z/Ang BuddyParam summon position info.
    /// </summary>
    public class SummonPos
    {
        // JsonExtensionData stores info in config file not present in class in order to retain settings between versions.
        [JsonExtensionData]
        private IDictionary<string, JToken>? _additionalData;

        public float X;
        public float Z;
        public float Ang;

        // Preset fields
        public string PresetName = "";
        public float X_increment;
        public float Z_increment;
        public bool EnemiesOffsetInitX; // Determines if X position will be negatively offset by X_Increment when calculating number of enemies in team.

        public bool IsPreset
        {
            get => (X_increment != 0 || Z_increment != 0);
        }
        public string Label
        {
            get
            {
                if (PresetName != "")
                    return PresetName;
                else
                {
                    return $"{X}x {Z}z {Ang}º";
                }
            }
        }

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
        public SummonPos(float x, float z, float ang, float xIncrement, float zIncremenet, string presetName, bool enemiesOffsetInitX = false)
        {
            X = x;
            Z = z;
            Ang = ang;
            X_increment = xIncrement;
            Z_increment = zIncremenet;
            PresetName = presetName;
            EnemiesOffsetInitX = enemiesOffsetInitX;
        }
        public SummonPos Clone()
        {
            SummonPos newPos = new();
            newPos.X = X;
            newPos.Z = Z;
            newPos.Ang = Ang;

            newPos.X_increment = X_increment;
            newPos.Z_increment = Z_increment;
            newPos.PresetName = PresetName;
            newPos.EnemiesOffsetInitX = EnemiesOffsetInitX;

            return newPos;
        }
    }

    public class BattleSpirit
    {
        // JsonExtensionData stores info in config file not present in class in order to retain settings between versions.
        [JsonExtensionData]
        private IDictionary<string, JToken>? _additionalData;

        [JsonIgnore]
        public bool Is_c0000 { get => CharaInitID != -1; }
        [JsonIgnore]
        public bool FollowPlayer { get => Team.FollowPlayer; } // Indicates of this summon will follow & warp to the player.

        public string BaseName = "";
        public string VariantName = "";
        public int BaseNpcID;
        public int BaseThinkID;
        public int CharaInitID = -1;
        public SpiritTeam Team = null!;
        public SummonPos Position = new(); // X, Z, Angle

        public decimal HpMult = 1;
        public decimal DamageMult = 1;
        public int Sp_StatScaling = -1; // ID of Stat Scaling SpEffect overwrite (if one was provided).
        public int Sp_SpecialScaling = -1; // Stores ID of newly created spEffect that holds HpMult and DamageMult modifiers.
        public List<int> BehaviorSpEffects = new(); // Additional spEffects that affect enemy variant behavior.

        public bool LongDistanceAggro = true;

        public List<int> SpecialEffects
        {
            get
            {
                List<int> effects = new();
                if (Sp_StatScaling > 0)
                {
                    if (Is_c0000)
                    {
                        // Calculate Lvl of assigned scaling spEffect, then calculate c0000 ID using that.
                        int idOffset = (Sp_StatScaling - SpiritBattlerResources.ScalingEffectBaseId) / 10; // Get Lvl offset (+10 -> +1 per level)
                        effects.Add(SpiritBattlerResources.c0000ScalingEffectBaseId + idOffset);
                    }
                    else
                    {
                        effects.Add(Sp_StatScaling);
                    }
                }
                if (Sp_SpecialScaling > 0)
                {
                    effects.Add(Sp_SpecialScaling);
                }
                if (MainForm.Config.SummonsVanishAfterDeath)
                {
                    effects.Add(SpiritBattlerResources.VanishAfterDeathSpEffect);
                }
                if (FollowPlayer)
                {
                    effects.Add(SpiritBattlerResources.FollowPlayerSpEffectId); // Permitted to follow player spEffect + StateInfo (required in tandem with BuddyParam pcFollowType 0)
                }
                effects.AddRange(BehaviorSpEffects);
                return effects;
            }
        }

        public BattleSpirit()
        { }

        public BattleSpirit Clone()
        {
            BattleSpirit spirit = new();
            spirit.BaseName = BaseName;
            spirit.VariantName = VariantName;
            spirit.BaseNpcID = BaseNpcID;
            spirit.BaseThinkID = BaseThinkID;
            spirit.CharaInitID = CharaInitID;
            spirit.Team = Team;
            spirit.HpMult = HpMult;
            spirit.DamageMult = DamageMult;
            spirit.Sp_StatScaling = Sp_StatScaling;
            spirit.Sp_SpecialScaling = Sp_SpecialScaling;
            spirit.Position = new SummonPos(Position.X, Position.Z, Position.Ang);
            spirit.LongDistanceAggro = LongDistanceAggro;
            spirit.BehaviorSpEffects = BehaviorSpEffects.ToList();
            return spirit;
        }
    }

    public class SpiritTeam
    {
        // JsonExtensionData stores info in config file not present in class in order to retain settings between versions.
        [JsonExtensionData]
        private IDictionary<string, JToken>? _additionalData;

        public string Name = "";
        public byte TeamType; // NpcParam enum
        public int PhantomParamID; // PhantomParam ID to insert into SpEffectVfxParam
        public decimal TeamHpMult = 1;
        public decimal TeamDamageMult = 1;
        public bool FollowPlayer = false;
        public SummonPos TeamPosition = new();
        public SpiritTeam()
        { }
        public SpiritTeam(string name, int phantomShaderID, byte teamType, bool followPlayer, SummonPos? teamPosition = null)
        {
            Name = name;
            PhantomParamID = phantomShaderID;
            TeamType = teamType;
            FollowPlayer = followPlayer;
            if (teamPosition != null)
                TeamPosition = teamPosition;
        }
        public SpiritTeam Clone()
        {
            SpiritTeam team = new();
            team.Name = Name;
            team.TeamType = TeamType;
            team.PhantomParamID = PhantomParamID;
            team.TeamHpMult = TeamHpMult;
            team.TeamDamageMult = TeamDamageMult;
            team.FollowPlayer = FollowPlayer;
            team.TeamPosition = TeamPosition.Clone();
            return team;
        }
    }
}
