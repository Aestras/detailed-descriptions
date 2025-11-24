using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class DartlingGunnerTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.DartlingGunner;

    public override string TextValue => "<u>Dart</u> attack (1d, 1p, .2s, ∞r, <i>Sharp</i>, 23° spread)";
}

public class DartlingGunnerUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.FocusedFiring, "+40% projectile lifespan (excludes 104 ability)\n<u>Dart</u> buffed: -14° spread (9°)"},
        {
            UpgradeType.LaserShock,
            "On-hit effect: <u>Laser Shock</u> (1d/1s, takes +1d from other Laser Shock Dartling Guns)."
        },
        {
            UpgradeType.LaserCannon,
            "<u>Dart</u> attack replaced with <u>Laser</u> (2d, 2md, +5p (6 (9p w/ 302)), .2s, ∞r, 3 radius, <i>Energy</i>). <u>Laser Shock</u> now lasts 2s."
        },
        {
            UpgradeType.PlasmaAccelerator,
            "<u>Laser</u> replaced with <u>Beam</u> (1d, 50p (150 w/ 402), .2s, ∞r, 2 radius, <i>Plasma</i>) " +
            "that at the tip does (2d, +10md, 50p (150 w/ 402), .2s, 4 radius). <u>Laser Shock</u> now lasts 5s."
        },
        {
            UpgradeType.RayOfDoom,
            "No tip effect, but <u>Beam</u> buffed: 30d (+110d to first hit), 0md, +950p (1000 (1025 w/ 502)), 6 radius (9 w/ 502), extends indefinitely. <u>Laser Shock</u> buffed: 20d/.1s, 5s duration"
        },

        {UpgradeType.AdvancedTargeting, "Camo."},
        {UpgradeType.FasterBarrelSpin, "0.66%s (.132)"},
        {
            UpgradeType.HydraRocketPods,
            "<u>Dart</u> attack replaced with <u>Rocket</u> (0d, 6p (8 w/ 032) (2 used up per Bloon), .132s, ∞r) that create <u>Blasts</u> on each hit (2d, 6p, 8 blast radius (12 w/ 032), <i>Normal</i>)."
        },
        {
            UpgradeType.RocketStorm,
            "<u>Rockets</u> and <u>Blasts</u> buffed: +2p (8 (10 w/ 042)).\nAbility (40s): For 7.5s, every 0.5s, fires a wave of 10 <u>Missiles</u> (5d, +1cd, 8p (10 w/032), ∞r, <i>Normal</i>, 90° (36° w/ 140))."
        },
        {
            UpgradeType.MAD,
            "<u>Rockets</u> replaced with <u>Mega Missiles</u> (0d, 450md, 20p (2 used up per Bloon), .4s, ∞r, <i>Normal</i>) that create <u>Mega Blasts</u> on each hit (3d, 8p, 8 blast radius (12 w/ 032), <i>Normal</i>).\nAbility <u>Missiles</u> buffed: +80p (18), +4cd (5), +250md."
        },

        {UpgradeType.FasterSwivel, "2x faster turn speed\n(180°/second to 440°/second)."},
        {UpgradeType.PowerfulDarts, "<u>Dart</u> attack buffed: +2p (3), <i>Shatter</i>, and increased projectile speed. All projectiles are slightly larger."},
        {
            UpgradeType.Buckshot,
            "<u>Dart</u> attack replaced with <u>Buckshot</u> (4d, 4p, 1.5s (1s w/ 023), 6j, 130r, 46° spread (18.6° w/ 103) <i>Shatter</i>) that knocks back non-MOAB Bloons (move backwards 300% speed (150% against Ceramics/damaged Leads) for 0.2s). 203 gains +3 shocked damage and 3d/1s."
        },
        {
            UpgradeType.BloonAreaDenialSystem,
            "Creates 4 copies of <u>Buckshot</u> attack. Gains 'Independent Targeting' option for barrels to shoot First, Last, Close Strong. Higher barrels can ignore some blocking obstacles"
        },
        {
            UpgradeType.BloonExclusionZone,
            "Creates 2 additional copies of <u>Buckshot</u> attack (6), <u>Buckshot</u> attack buffed: +6j (12), +4d (8), +2p (6). Top four barrels can ignore some blocking obstacles. 205 gains +3 (6) shocked damage and +3d(6)/1s"
        },
    };
}