using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class BombShooterTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.BombShooter;

    public override string TextValue =>
        "<u>Bomb</u> attack (1.5s, 40r), creates on-hit <u>Explosion</u> (1d, 22p, <i>Explosion</i>)";
}

public class BombShooterUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.BiggerBombs, "+6p (28)"},
        {UpgradeType.HeavyBombs, "+1d (2), +10p (38)"},
        {UpgradeType.ReallyBigBombs, "+2d (4), +42p (80), push back 20u (cannot affect Blimps))"},
        {UpgradeType.BloonImpact, "+3r (43). Applies stun status for 1.4s (cannot affect Blimps)."},
        {UpgradeType.BloonCrush, "+21d (24), <i>Normal</i>\nStun buffed: 2s duration, can affect Blimps. Push back buffed: can affect Blimps (5u)"},

        {UpgradeType.FasterReload, "75%s (1.125)"},
        {UpgradeType.MissileLauncher, "80%s (0.9), +4r (44), faster projectile speed"},
        {UpgradeType.MOABMauler, "+15md (16), +5r (49)"},
        {
            UpgradeType.MOABAssassin,
            "+30md (31), +3cd (5), +5r (54).\nAbility (30s cooldown): 750 <i>Explosion</i> damage to target Blimp, which can pierce blimp layers, and creates a (3d, 100p) <i>Explosion</i>."
        },
        {
            UpgradeType.MOABEliminator,
            "99md (100), <i>Normal</i>.\nAbility (10s cooldown): 4500 <i>Explosion</i> damage to target Blimp, which can pierce blimp layers, and creates a (3d, 100p) <i>Explosion</i>."
        },

        {UpgradeType.ExtraRange, "+12r (52)"},
        {
            UpgradeType.FragBombs,
            "+2r (54)\nOn-hit: <u>Frags</u> (1d (2d,6d,36d w/ 202,302,502), 1p (2p,3p,20p  w/ 302,402,502), 8j (12 w/ 302), <i>Sharp</i>)"
        },
        {UpgradeType.ClusterBombs, "<u>Frags</u> replaced by <u>Clusters</u> (1d (+1 w/ 203), 8p (+6,+16 w/, 103,203) 8j, <i>Explosion</i>). 50% larger blast radius w/ 203."},
        {
            UpgradeType.RecursiveCluster,
            "+1d (2), 18p. Every other shot does a <u>Supercluster</u>, which also makes a <u>Subcluster</u> (2d, 32p (56p,96p w/ 104,204), <i>Explosion</i>)."
        },
        {
            UpgradeType.BombBlitz,
            "+3d (5), 80%s (0.9). Every shot does a <u>Super Cluster</u>.\nPassive (60s cooldown): Before something leaks, delete it, and all other Bloons (including camo) and MOABs, then deals 2000 damage to all other Blimps, can pierce blimp layers."
        },
    };
}