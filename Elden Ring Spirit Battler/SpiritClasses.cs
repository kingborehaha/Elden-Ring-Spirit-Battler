using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldenRingSpiritBattler
{
    /// <summary>
    /// Object derived from .txt resource that contains each unique enemy's info.
    /// </summary>
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

    /// <summary>
    /// Contains X/Z/Ang BuddyParam summon position info.
    /// </summary>
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

        public decimal HpMult = 1;
        public decimal DamageMult = 1;
        public int Sp_StatScaling = -1; //
        public int Sp_SpecialScaling = -1; // Stores ID of newly created spEffect that holds HpMult and DamageMult modifiers
        public List<int> SpecialEffects
        {
            get
            {
                List<int> effects = new();
                effects.Add(Sp_StatScaling);
                //if (Team.BonusStatScalingEffect > 0)
                    //effects.Add(Team.BonusStatScalingEffect);
                if (Sp_SpecialScaling > 0)
                    effects.Add(Sp_SpecialScaling);
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
            spirit.Team = Team;
            spirit.Position = new SummonPos(Position.X, Position.Z, Position.Ang);
            spirit.HpMult = HpMult;
            spirit.DamageMult = DamageMult;
            spirit.Sp_StatScaling = Sp_StatScaling;
            spirit.Sp_SpecialScaling = Sp_SpecialScaling;
            return spirit;
        }
    }

    public class SpiritTeam
    {
        public string Name = "";
        public byte TeamType; // NpcParam enum
        public int PhantomParamID; // PhantomParam ID to insert into SpEffectVfxParam
        public decimal TeamHpMult = 1;
        public decimal TeamDamageMult = 1;
        public SummonPos TeamPosition = new();
        public SpiritTeam()
        { }
        public SpiritTeam(string name, int phantomShaderID, byte teamType)
        {
            Name = name;
            PhantomParamID = phantomShaderID;
            TeamType = teamType;
        }
        public SpiritTeam Clone()
        {
            SpiritTeam team = new();
            team.Name = Name;
            team.TeamType = TeamType;
            team.PhantomParamID = PhantomParamID;
            team.TeamHpMult = TeamHpMult;
            team.TeamDamageMult = TeamDamageMult;
            team.TeamDamageMult = TeamDamageMult;
            team.TeamPosition.X = TeamPosition.X;
            team.TeamPosition.Z = TeamPosition.Z;
            team.TeamPosition.Ang = TeamPosition.Ang;
            return team;
        }
    }

    public class SearchFilterClass
    {
        public List<string> Results_Cache = new();
        public List<string> Results_Filtered = new();
        public string SearchFilter_Cache;
        public string SearchFilter;
        public SearchFilterClass() { }
    }

}
