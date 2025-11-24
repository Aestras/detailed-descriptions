using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class DartMonkeyTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.DartMonkey;
    public override string TextValue => "<u>Dart</u> attack (1d, 2p, 0.95s, 32r, <i>Sharp</i>)";
}

public class DartMonkeyUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.SharpShots, "+1p (3)"},
        {UpgradeType.RazorSharpShots, "+2p (5)"},
        {
            UpgradeType.SpikeOPult,
            "<u>Dart</u> replaced by <u>Spikeball</u> (2d, 18p, 1.15s, 36.5r, <i>Shatter</i>). <u>Spikeball</u> can rebound off walls and re-hit Bloons after rebounding."
        },
        {
            UpgradeType.Juggernaut,
            "<u>Spikeball</u> replaced by <u>Juggernaut</u> (2d, 3cd, 2fd, 60p, 36.5r, 1.0s, <i>Normal</i>) that knocks back non-MOAB Bloons (move backwards 600% speed (200% against Ceramics/Leads (900%,300% w/ 302)) for 0.15s).\n<u>Juggernaut</u> can rebound off walls and re-hit Bloons after rebounding."
        },
        {
            UpgradeType.UltraJuggernaut,
            "<u>Juggernaut</u> replaced by <u>Ultrajugg</u> (5d, +8cd, +20ld, +5fd, 210p, 1.0s, 36.8r, <i>Normal</i>). <u>Ultrajugg</u> can rebound off walls and re-hit Bloons after rebounding, " +
            "and emits 6 <u>Juggernauts</u> (50p, no knock back) upon rebounding, 50p remaining, or when it expires."
        },

        {UpgradeType.QuickShots, "85%s (0.8075)"},
        {UpgradeType.VeryQuickShots, "78.43%s (0.6365)"},
        {UpgradeType.TripleShot, "+2j (3), 75%s, (0.4774), 15° spread"},
        {
            UpgradeType.SuperMonkeyFanClub,
            "50%s (0.2387)\nAbility (50s cooldown, 15s duration): Transforms 10 nearest Dart Monkeys (upgraded up to 242) into Superfans " +
            "that have a <u>Dart</u> attack (1d, 2p, 0.06s, 40r, <i>Sharp</i>), inheriting buffs to the transformed tower (excluding 3j from Triple Shot)."
        },
        {
            UpgradeType.PlasmaMonkeyFanClub,
            "Ability (50s cooldown, 15s duration): Transforms 20 nearest dart monkeys (upgraded up to 252) into Plasmafans " +
            "that have a <u>Plasma</u> attack (2d, 5p, 0.03s, 40r, <i>Plasma</i>), inheriting buffs to the transformed tower (excluding 3j from Triple Shot)."
        },

        {UpgradeType.LongRangeDarts, "+8r (40), +35% projectile lifespan."},
        {
            UpgradeType.EnhancedEyesight, "+8r (48), 7% projectile lifespan.\nGains Camo detection."
        },
        {UpgradeType.Crossbow, "<u>Dart</u> replaced by <u>Bolt</u> (3d, 4p (7,12 w/ 103,203), 0.95s, 60r, <i>Sharp</i>)"},
        {
            UpgradeType.SharpShooter, "+3d (6), 50%s(0.475).\n" +
                                      "50d <u>Crit</u> every 10 shots."
        },
        {
            UpgradeType.CrossbowMaster, "+2d (8), +5p (8) (16,24 w/ 105,205), +20r (80), 50%s,(0.2375), <i>Normal</i>.\n" +
                                        "80d <u>Crit</u> now occurs every 5 shots."
        },
    };
}