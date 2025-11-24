using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class TackShooterTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.TackShooter;

    public override string TextValue => "<u>Tacks</u> attack (1d, 1p, 1.12s, 23r, 8j, <i>Sharp</i>)";
}

public class TaskShooterUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.FasterShooting, "75%s (.84)"},
        {UpgradeType.EvenFasterShooting, "66%s (0.63)"},
        {UpgradeType.HotShots, "+1d (2), <i>Normal</i>."},
        {
            UpgradeType.RingOfFire,
            "<u>Tacks</u> replaced by <u>Firezone</u> (5d (6,7 w/ 401,402), 30p (45p w/ 420), 0.315s, <i>Fire</i>)."
        },
        {
            UpgradeType.InfernoRing,
            "+3d (8, 9,10 w/ 501,502), +15p (45, 60 w/ 520) +4md, 0.1s, +11.5r (34.5, 38.41,42.32 w/ 510,520).\nGains <u>Meteor</u> attack (700d (1000d w/ 502), 1p (2p w/520), 4.0s, ∞r, <i>Fire</i>, Camo, follows targeting) " +
            "that creates <u>Explosion</u> (50d, 10p, 18 blast radius) and applies <u>Burn</u> status (50d/1s, 4.1s duration, <i>Fire</i>)."
        },

        {UpgradeType.LongRangeTacks, "+4r (27)"},
        {UpgradeType.SuperRangeTacks, "+4r (31), +1p (2)"},
        {UpgradeType.BladeShooter, "<u>Tacks</u> replaced by <u>Blades</u> (1d, 8p, 46r, <i>Shatter</i>)"},
        {
            UpgradeType.BladeMaelstrom,
            "<u>Blades</u>: +1d (2). Ability (20s cooldown): Emits <u>Storm Blades</u> (2d, 100p, 0.045s (0.038,0.0325 w/ 140,240), 2j, <i>Shatter</i>) in a clockwise spiral for 3s."
        },
        {
            UpgradeType.SuperMaelstrom,
            "+3d (5), +5cd, <i>Normal</i>. Ability (20s cooldown): Emits <u>Storm Blades</u> (2d, +8cd 300p, 0.045s, 4j, <i>Shatter</i>) for 9s."
        },

        {UpgradeType.MoreTacks, "+2j (10)"},
        {UpgradeType.EvenMoreTacks, "+2j (12)"},
        {UpgradeType.TackSprayer, "+1p (2, 3 w/ 023), +4j (16)"},
        {UpgradeType.Overdrive, "+33.33%s (0.3733, 0.28,0.21 w/ 104,204)."},
        {UpgradeType.TheTackZone, "+1md, +1p (2, 10 w/ 025), 66%s (0.224, 0.168,0.126 w/ 105,205), +7r (30, 33.91,50 w/ 015,025), +16j (32)"},
    };
}