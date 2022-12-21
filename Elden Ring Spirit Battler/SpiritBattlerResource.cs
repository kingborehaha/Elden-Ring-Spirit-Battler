﻿using System;

namespace EldenRingSpiritBattler
{
    public static class SpiritBattlerResources
    {
        public enum TeamTypeEnum : byte
        {
            Player = 1,
            FriendlyPhantom = 2,
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
            Unknown24 = 24,
            UnusedDS3_StrongEnemy = 25,
            FriendlyNPC = 26,
            HostileNPC = 27,
            CoopNPC = 28,
            Object = 30,
            DS3_CoopMadPhantom = 31,
            DS3_InvaderMadPhantom = 32,
            ArchEnemyTeam = 33,
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
            C19 = 19,
            C24 = 24,
            C25 = 25,
            C60 = 60,
            C80 = 80,
            C203 = 203,
            C900 = 900,
            C920 = 920,
        };

        public enum StatScalingEnum
        {
            Default = -99,
            None = -1,
            Level_1 = 7000,
            Level_2 = 7001,
            Level_3 = 7002,
            Level_4 = 7003,
            Level_5 = 7004,
            Level_6 = 7005,
            Level_7 = 7006,
            Level_8 = 7007,
            Level_9 = 7008,
            Level_10 = 7009,
            Level_11 = 7010,
            Level_12 = 7011,
            Level_13 = 7012,
            Level_14 = 7013,
            Level_15 = 7014,
            Level_16 = 7015,
            Level_17 = 7016,
            Level_18 = 7017,
            Level_19 = 7018,
            Level_20 = 7019,
            Level_21 = 7020,
        };

        public static string[] randomTeamNames = new string[]
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
            "Energetic Susans",
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
        };
    }
}