using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class SuperMonkeyTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.SuperMonkey;

    public override string TextValue => "<u>Dart</u> attack (1d, 1p, 0.045s, 50r, <i>Sharp</i>).";
}

public class SuperMonkeyUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.LaserBlasts, "<u>Dart</u> replaced with <u>Laser</u> (1d, 2p, <i>Energy</i>)."},
        {UpgradeType.PlasmaBlasts, "<u>Laser</u> replaced with <u>Plasma</u> (1d, 2p, 0.03s, <i>Plasma</i>)."},
        {UpgradeType.SunAvatar, "<u>Plasma</u> replaced with <u>Sun Beams</u> (6p (7,9 w/ 310,320), 3j, <i>Plasma</i>)."},
        {
            UpgradeType.SunTemple,
            "<u>Sun Beams</u> replaced by <u>Sunblast</u> (5d, 20p (21,23 w/ 410,420), 0.06s, 65r, <i>Normal</i>). (Look online for Sacrifice stuff lol)."
        },
        {UpgradeType.TrueSunGod, "+10d (15). (Look online for Sacrifice stuff lol)."},

        {UpgradeType.SuperRange, "+1p (2), +10r (60)"},
        {UpgradeType.EpicRange, "+2p (4), +12r (72, 75 w/ 022), 75% faster projectile speed."},
        {UpgradeType.RoboMonkey, "<u>Dart</u> replaced by <u>Blaster</u> (1d, 5p (6 w/130), 0.045s (0.03 w/ 230), 2j, <i>Sharp</i> (<i>Energy</i>,<i>Plasma</i> w/ 130,230)).\nGuns can target independently. 10d <u>Crits</u> every 15-20 shots."},
        {
            UpgradeType.TechTerror,
            "<u>Blaster</u>: +1p (7, 8 w/ 140), <i>Plasma</i>. Ability (45s cooldown): 2600d, 2000p, 70r. Every 3rd use <u>Crits</u> for 3900d."
        },
        {
            UpgradeType.TheAntiBloon,
            "+4d (5), +5p (12, 13 w/ 150), +10r (82, 85 w/ 052), <i>Normal</i>. 50d Crits every 13-17 shots. Ability (30s cooldown): 10400d (15600 on <u>Crit</u>), 120r."
        },

        {
            UpgradeType.Knockback,
            "Knocks back Bloons on-hit (non-MOAB Bloons move backwards 25% speed, Ceramics/Leads move forwards 40% speed, non-BAD MOABs move forward 70% speed) for 0.5s."
        },
        {UpgradeType.Ultravision, "Camo.\n+3r (53), +1d to Camo."},
        {
            UpgradeType.DarkKnight,
            "<u>Dart</u> replaced by <u>Monkeyrang</u> (1d, 2md (3), +1d to Camo, 4p (5,7 w/ 103/013,023), <i>Sharp</i> (<i>Energy</i>,<i>Plasma</i> w/ 130,230)). Knock back buffed: Ceramics/Leads move forwards 10% speed.\n" +
            "Ability (20s cooldown): Teleport to a chosen point within range."
        },
        {
            UpgradeType.DarkChampion,
            "+1d (2), +1md (3), +2cd, +1d (2) to Camo. +4p (8, 9,11 w/ 104/014,024), 50%s (0.0225), +4r (57, 67,79 w/ 014,024) jumps to targets within 57r (67,79 w/ 014,024), <i>Normal</i>. <u>Knockback</u> buffed: Leads/Ceramics stop completely. Ability buffed: Can teleport anywhere."
        },
        {
            UpgradeType.LegendOfTheNight,
            "+8d (10), +22md (25), +2cd (4), +2d (4) to Camo. +8p (16, 17,19 w/ 104/014,024). Passive (180s cooldown): Before something leaks (excluding Boss), delete it, and anything else that would leak in the next 8s."
        },
    };
}