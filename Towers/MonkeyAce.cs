using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class MonkeyAceTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.MonkeyAce;

    public override string TextValue =>
        "<u>Radial Darts</u> attack (1d, 5p, 8j, 1.68s, <i>Sharp</i>, passive). Flies on a circular path with radius 80, or a figure 8 or figure infinite with radii 40.";
}

public class MonkeyAceUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.RapidFire, "All weapons: 75%s (1.26)"},
        {UpgradeType.LotsMoreDarts, "<u>Radial Darts</u> buffed: +4j (12)"},
        {
            UpgradeType.FighterPlane,
            "Flies 20% faster, gains <u>MOAB Missile</u> attack (18md, 4p (6p w/ 310), 4.0s, 2j, <i>Explosion</i>, homing, Blimps only)"
        },
        {
            "Operation: Dart Storm",
            "<u>Radial Darts</u> buffed: +4j (16). <u>MOAB Missile</u> buffed:+6md (24). All attacks: 50%s."
        },
        {
            UpgradeType.SkyShredder,
            "<u>Radial Dart</u> buffed: +2d (3), +2cd, +3p (8), 50%s (0.315), +16j (32), <i>Normal</i>. <u>MOAB Missile</u> buffed: +126md (150), +1p (5) (7 w/ 510), <i>Normal</i>."
        },

        {UpgradeType.ExplodingPineapple, "Gains <u>Pineapple</u> attack (1d, 20p (32p w/ 011), 1.6s (1.2 w/ 110), <i>Explosion</i>)"},
        {UpgradeType.SpyPlane, "Camo, All weapons (except <u>MOAB Missile</u>): 2xd to Camos."},
        {
            UpgradeType.BomberAce,
            "<u>Pineapple</u> replaced by <u>Bombing Run</u> (3d, 20p (32p w/ 031), 1.6s (1.2s w/ 130), 4j, <i>Explosion</i>) that's dropped on path"
        },
        {
            UpgradeType.GroundZero,
            "<u>Bombing Run</u> buffed: +12d (15), +20p (40, 52 w/ 041). Ability (35s cooldown): 700d (+700d to camos) bomb with 2000p, <i>Normal</i>."
        },
        {
            UpgradeType.TsarBomba,
            "<u>Bombing Run</u> buffed: +5d (20), +10cd, <i>Normal</i>. Ability (35s cooldown): 3000d bomb (+3000d to camos) with 5000p, with an 8s stun to anything that survives."
        },

        {UpgradeType.SharperDarts, "<u>Radial Darts</u> buffed: +3p (8)"},
        {
            UpgradeType.CenteredPath,
            "Gains 'Centred Path' targeting (fly on a circular path in the center of the screen or selected spot with radius 90)."
        },
        {UpgradeType.NevaMissTargeting, "<u>Radial Darts</u> buffed: faster projectile speed and homing."},
        {
            UpgradeType.Spectre,
            "Buffed <u>Radial Darts</u>: +2d (3). Gains <u>Barrage</u> attack (0.06s (0.045 w/ 104), ∞r) which alternately fires <u>Darts</u> (8d, 4p, <i>Sharp</i>) and <u>Bombs</u> (3d, +5cd, 20p (30p w/ 014), <i>Explosion</i>). Homing. "
        },
        {
            UpgradeType.FlyingFortress,
            "Buffed <u>Radial Darts</u>: +3d (6). <u>Barrage</u> buffed: +2d (5), +10md, +2j (3), 66.66%s (0.04, 0.03 w/ 105). The 3 projectiles have separate targeting (first, last, and close). All attacks: <i>Normal</i>."
        },
    };
}