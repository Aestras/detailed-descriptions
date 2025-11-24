using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class BoomerangMonkeyTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.BoomerangMonkey;

    public override string TextValue => "<u>Boomerang</u> attack (1d, 4p, 43r, 1.2s, <i>Sharp</i>)";
}

public class BoomerangMonkeyUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.ImprovedRangs, "+4p (8)"},
        {UpgradeType.Glaives, "<u>Boomerang</u> replaced by <u>Glaive</u> (1d, 13p, 1.2s, 43r, <i>Sharp</i>, increased projectile size.)"},
        {UpgradeType.GlaiveRicochet, "+17p (30), <u>Glaive</u> buffed: bounces from target to target, maximum bounce distance 60u, bouncing ignores blocking objects"},
        {UpgradeType.MOARGlaives, "+1cd, +30p (60), 50%s (0.6), bounce distance +120u (180), projectile speed +70%"},
        {
            UpgradeType.GlaiveLord,
            "Gains <u>Orbital Glaive</u> attack (4d (6d w/502)), 4cd, 200p, 0.05s, 30r zone (40r w/ 501), camo, <i>Sharp</i> (<i>Normal</i> w/ 502)). <u>Glaive</u> buffed: +5d (6 (8d w/ 502)), +10cd, ∞u bounce distance, can re-hit Bloons 0.6s after bouncing, first Blimp hit applies shred effect (100d/1.0s, 10s duration)."
        },

        {UpgradeType.FasterThrowing, "75%s (.9)"},
        {UpgradeType.FasterRangs, "66%s (0.6), faster projectile speed"},
        {UpgradeType.BioncBoomerang, "+2md (3), 0.238s"},
        {UpgradeType.TurboCharge, "Ability (45s cooldown): +1d and 7× faster (0.04s) for 10s."},
        {
            UpgradeType.PermaCharge,
            "+3d (4 (8 w/ 052)), 0.04s\nAbility (45s cooldown): +8d (+10d w/052) for 15s."
        },

        {UpgradeType.LongRangeRangs, "+14.19r (57.19)"},
        {UpgradeType.RedHotRangs, "+1d, <i>Normal</i>"},
        {
            UpgradeType.KylieBoomerang,
            "<u>Boomerang</u> replaced by <u>Kylie</u> (2d, 18p, 1.2s, 57.19r, <i>Normal</i>) that travels in a straight line and can re-hit Bloons every .3s"
        },
        {
            UpgradeType.MOABPress,
            "Gains <u>Heavy Kylie</u> attack (1d, +4md (5), 200p (300p w/ 104, 420p w/ 204), 10.0s, <i>Normal</i>) that targets and pushes back Blimps (2u,1u,0.5u (3u,1.5u,0.75u w/ 204) for MOAB,BFB,DDT/ZOMG) below BAD and can re-hit every 0.1s."
        },
        {
            UpgradeType.MOABDomination, "<u>Kylie</u> buffed: +10d (12), +34p (54 (58,81 w/ 105,205)), 50%s (0.6). " +
                                        "<u>Heavy Kylie</u> buffed: +20md (25), +100p (300 (400,520 w/ 105,205)) 50%s (4s), 100r, 0.25s stun, can target BADs, creates explosion effect instead of returning: " +
                                        "100d, 40p (50 w/ 205), <i>Normal</i>, 50 blast radius (75 w/ 205), applies burn status (50d/1s, 4s duration), ignores blocking objects."
        },
    };
}