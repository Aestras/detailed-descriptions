using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class GlueGunnerTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.GlueGunner;

    public override string TextValue =>
        "<u>Glue</u> attack (0d, 1p, 1.0s, 46r, <i>Acid</i>) that applies <u>Glued</u> (11s duration, 50% slow, 3 layers)";
}

public class GlueGunnerUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.GlueSoak, "<u>Glued</u> status soaks through all non-Blimp layers."},
        {
            UpgradeType.CorrosiveGlue,
            "<u>Glued</u> status buffed: 1d/2s and can overwrites weaker effects. <u>Glue</u> can affect Blimps, but doesn't slow and immediately expires."
        },
        {UpgradeType.BloonDissolver, "+1p (2), +50%s (0.5). <u>Glued</u> status buffed: 1d/.5s, 2cd/.5 (2)"},
        {UpgradeType.BloonLiquefier, "<u>Glued</u> status buffed: 1d/.1s, 2cd/.1s. <u>Glued</u> Bloons drop <u>Puddles</u> (4d, 3p (4 w/ 410), 7.7s (16.8 w/ 401) duration, <i>Acid</i>)) on pop."},
        {UpgradeType.TheBloonSolver, "2j, 4p, 25%s (0.25), impact. <u>Glued</u> status buffed: +8cd/0.1s and +4md/0.1s. <u>Puddles</u> buffed: 15d, 4p (5 w/ 510)."},

        {UpgradeType.BiggerGlobs, "+1p (2)"},
        {UpgradeType.GlueSplatter, "+2p (4), impact (1p)"},
        {UpgradeType.GlueHose, "33.33%s (0.333), +12r (58)"},
        {
            UpgradeType.GlueStrike,
            "Ability (30s cooldown): Applies buffed <u>Glued</u> (take +2d (+3 w/ 240), removes Lead + Frozen immunities) to all Bloons, (+Blimps w/ 240). Soaks 3 (∞ w/ 140) layers. Will refresh duration of stronger glue instead of replacing."
        },
        {
            UpgradeType.GlueStorm,
            "Ability buffed (40s cooldown): Every second for 10s, applies <u>Glued</u> to all valid targets with twice the duration."
        },

        {UpgradeType.StickierGlue, "<u>Glued</u> status buffed: +13s duration (24s)."},
        {UpgradeType.StrongerGlue, "<u>Glued</u> status buffed: 75% slow."},
        {UpgradeType.MOABGlue, "Can now target Blimps, but slowed for less (37.5%) and for half the duration (12s)."},
        {
            UpgradeType.RelentlessGlue,
            "<u>Glued</u> Bloons drop the glue when popped, to be picked up by the next target, lasts 5s."
        },
        {
            UpgradeType.SuperGlue,
            "+50md (50), +5p (6), <u>Glued</u> status buffed: 1d/2.3s (2.0s with 205); Bloons are slowed 100%; MOABs and DDTs are slowed 100% for the first 5s; BFBs are slowed 95% for the first 2.5s; ZOMGs are slowed 90% for the first 0.75s."
        },
    };
}