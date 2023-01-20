using System;

namespace EldenRingSpiritBattler
{
    public static class SpiritBattlerResources
    {
        public static readonly uint buddyLimit = 10; // Limit with buddyParam successive IDs.

        private static readonly float magnitude = 1; // Unimplemented
        private static readonly float incrementBase = 1.5f;
        public static readonly Dictionary<string, SummonPos?> teamSummonPresetDict = new()
        {
            {"Column Left", new SummonPos(-10*magnitude, 13.5f*magnitude, 90, 0, incrementBase, "Column Left")},
            {"Column Right", new SummonPos(10*magnitude, 13.5f*magnitude, -90, 0, incrementBase, "Column Right")},
            {"Row Close", new SummonPos(0, 3*magnitude, 0, incrementBase, 0, "Row Close", true)},
            {"Row Far", new SummonPos(0, 24*magnitude, -180, incrementBase, 0, "Row Far", true)},
            {"Manual Offset", null},
        };

        /// <summary>
        /// List of NpcParam IDs that should not be assigned a phantom VFX, as it won't work very well.
        /// </summary>
        public static readonly List<int> enemyPhantomBlacklist = new()
        {
            22000000, // Elden Beast
            21500000 // Wisp
        };

        public enum TeamTypeEnum : byte
        {
            Player = 1, // Mutual hate, mutual hurt
            FriendlyPhantom = 2,
            GreyGhost = 4,
            WanderingGhost = 5, // No hate or hurt
            Enemy = 6,
            Boss = 7,
            Indiscriminate = 29,
            UnusedDS3Unk_3 = 3,
            UnusedDS3Unk_4 = 4,
            Passive = 5,
            Unknown8 = 8,
            HostileAlly = 9,
            Torrent = 10,
            Dragon = 11,
            UnusedDS3_BattleAlly = 12,
            UnknownDS3_Invader = 13,
            UnusedDS3_Neutral = 14,
            UnusedDS3_Charmed = 15,
            Invader = 16,
            UnusedDS3_Invader3 = 17,
            UnusedDS3_Invader4 = 18,
            UnusedDS3_Host = 19,
            UnusedDS3_Coop = 20,
            UnusedDS3_Hostile = 21,
            UnusedDS3_WanderingPhantom = 22,
            UnusedDS3_Enemy1 = 23,
            Beast = 24,
            UnusedDS3_StrongEnemy = 25,
            FriendlyNPC = 26,
            HostileNPC = 27,
            CoopNPC = 28,
            Object = 30,
            DS3_CoopMadPhantom = 31,
            DS3_InvaderMadPhantom = 32,
            ArchEnemy = 33,
            SpiritSummon = 47,
            Unknown48 = 48,
            Unknown49 = 49,
            Unknown50 = 50,
            Unknown51 = 51,
            Unknown52 = 52,
            Unknown54 = 54,
            Unknown55 = 55,
            Unknown56 = 56,
            Unknown57 = 57,
            Unknown58 = 58,
            Unknown59 = 59,
            Unknown60 = 60,
            Unknown61 = 61,
            Unknown63 = 63,
            Unknown65 = 65,
            Unknown66 = 66,
        };

        public enum PhantomEnum
        {
            // TODO
            None = -1,
            GreyNoGlow = 1,
            Grey = 18,
            CyanBright = 19,
            //low glow//SlightWhite = 28, 
            YellowBright = 29,
            //low glow//C32 = 32,
            Gold = 44,
            //CyanBright2 = 50,
            WhiteDull = 51,
            RedInvader = 60,
            BrownSummon = 61,
            Red62 = 62,
            Blue70 = 70,
            WhiteSummon = 200,
            White201 = 201,
            Red202 = 202,
            Red203 = 203,
            DarkGrey = 211,
            //low glow = 220,
            WhiteBright = 230,
            Salmon = 240,
            GreyBlueOutline = 250,
            BlueBrightOutline = 260,
            GoldBright = 270,
            WhiteOutline = 290,
            BlueBrightGhost = 300,
            BlueLight = 310,
            WhiteFaintOutline = 320,
            GhostLightBlue50 = 330,
            //340,
            GhostGrey50 = 350,
            GhostWhite30 = 900,
            GhostWhite50 = 901,
            GhostRed50 = 902,
            //WhiteGhost30 = 910,
            Blue = 800,
            GreySlight = 803,
            RedStronger = 804,
            RedFaintEdge = 805,
            Invisible = 810, // Invisible string checked by rng phantom picker
            BlueStrong = 811,
            BrownSlight = 812,
            //813,
            GhostGrey60 = 820,
            YellowPale = 821,
            //890,
            MostlyInvisible = 891, // Invisible string checked by rng phantom picker
            GhostBrown30 = 920,
            GhostBrown50 = 921,
            //GhostRed50 = 922,
            //GhostBrown = 930,
            White = 998,
            ///White = 999,

        };

        /*
        public class StatScaler
        { 
        }
        */

        public static int c0000ScalingEffectOffset = 12350; //base scaling effect ID is 7000, base c0000 scaling is 19350
        /// </summary>
        public enum StatScalingEnum
        {
            Default = -99,
            None = -1,
            Lvl1 = 7000,
            Lvl2 = 7001,
            Lvl3 = 7002,
            Lvl4 = 7003,
            Lvl5 = 7004,
            Lvl6 = 7005,
            Lvl7 = 7006,
            Lvl8 = 7007,
            Lvl9 = 7008,
            Lvl10 = 7009,
            Lvl11 = 7010,
            Lvl12 = 7011,
            Lvl13 = 7012,
            Lvl14 = 7013,
            Lvl15 = 7014,
            Lvl16 = 7015,
            Lvl17 = 7016,
            Lvl18 = 7017,
            Lvl19 = 7018,
            Lvl20 = 7019,
            Lvl21 = 7020,
            /*
            Lvl1Human = 19350;
            Lvl2Human = 19351;
            Lvl3Human = 19352;
            Lvl4Human = 19353;
            Lvl5Human = 19354;
            Lvl6Human = 19355;
            Lvl7Human = 19356;
            Lvl8Human = 19357;
            Lvl9Human = 19358;
            Lvl10Human = 19359;
            Lvl11Human = 19360;
            Lvl12Human = 19361;
            Lvl13Human = 19362;
            Lvl14Human = 19363;
            Lvl15Human = 19364;
            Lvl16Human = 19365;
            Lvl17Human = 19366;
            Lvl18Human = 19367;
            Lvl19Human = 19368;
            Lvl20Human = 19369;
            Lvl21Human = 19370;
            */
        };

        public static readonly string[] randomTeamNames = new string[]
        {
            "Cowboys",
            "Orbists",
            "Sun Deniers",
            "The Chosen",
            "Solaire's Pals",
            "Peasant Army",
            "Party of Fools",
            "Elden Nerds",
            "Little Birthday Boys",
            "Ravens",
            "The Yharnam Shadows",
            "Patch's Patches",
            "The Dark Souls",
            "Scarlet Simps",
            "Dung Eaters",
            "Mensis Maniacs",
            "Bloodshades",
            "Sen’s Sneks",
            "Sen’s Simps",
            "Grafting Fodder",
            "The Elderly",
            "Sophists",
            "The Aristocats",
            "Fat Cats",
            "Lyndon B's Babes",
            "White Fishes",
            "Speedrunners",
            "Erdtree Huggers",
            "Gamers",
            "?TeamName?",
            "Havel's Heavyweights",
            "Drangleic Apologists",
            "Discalceate Devotees",
            "The Boilprawn Boys",
            "The Poopshitters",
            "The Dungshitters",
            "The Peepissers",
            "D's Nuts",
            "Gwyn's Sun Fuckers",
            "Big Bois, Big Poise",
            "Moon Enjoyers",
            "Gwynevere's GFs",
            "Convicted Gamists",
            "The Gatekeepers",
            "Crestfallen Crew",
            "Rotund Ruffians",
            "Johns of the Dark",
            "Vomitous Diamonds",
            "Diamond Dogs",
            "Alva's Omegas",
            "Pissed Pants",
            "Unhinged Cats",
            "Amazing Chests",
            "xX_DarkMoonBlades_Xx",
            "Stardust Crusaders",
            "Disco Heretics",
            "The Purple Moss Clumps",
            "The Cohesive Unit",
            "Silver K***hts"
        };
    }
}