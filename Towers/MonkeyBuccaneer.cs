using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class MonkeyBuccaneerTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.MonkeyBuccaneer;

    public override string TextValue =>
        "<u>Dart</u> attack (1d, 4p, 1.0s, 60r, <i>Sharp</i>) (Also shoots behind Boat if there are targets there).";
}

public class MonkeyBuccaneerUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        { UpgradeType.FasterShootingBuccaneer, "<u>Dart</u> and <u>Grapes</u>: 75%s (0.75 for Dart, 0.975 for Grapes)" },
        { UpgradeType.DoubleShotBuccaneer, "<u>Dart</u> and <u>Grapes</u>: +1j (2 for Dart, 6 for Grapes)" },
        { UpgradeType.Destroyer, "<u>Dart</u> and <u>Grapes</u>: 20%s (0.15 for Dart, 0.195 for Grapes)" },
        {
            UpgradeType.AircraftCarrier,
            "Spawns three <u>Planes</u>: <u>Forward Darts</u> (2d, 4p (6 w/ 401), 0.18s, 2j, <i>Sharp</i>), " +
            "<u>Radial-Darts</u> (4d, 9p (11 w/ 401), 1.2s (1.0s w/ 410), 8j (6 w/ 410), <i>Sharp</i> (<i>Fire</i> w/ 420), 420 applies <u>Burn</u>. <u>Burn</u> status buffed: +2d (4).) , <u>MOAB Missile</u> (15md, 3p, 3.0s, <i>Explosion</i>, Blimps only)"
        },
        {
            UpgradeType.CarrierFlagship,
            "<u>Darts</u> buffed: +4p (7). <u>Forward Darts</u> buffed: +3cd, +3p (7). <u>Radial-Darts</u> buffed: +3cd, +5p (14). " +
            "<u>MOAB Missile</u> buffed: +15md (30), +1p (4), 50%s (1.5), <i>Normal</i>. <u>Burn</u> status buffed: +5d (9). Buffs all water towers (including itself) and Aces 85%s."
        },

        { UpgradeType.GrapeShot, "Gains <u>Grapes</u> attack (1d, 1p, 1.3s, 5j (10j w/ 210), <i>Sharp</i>)" },
        {
            UpgradeType.HotShot,
            "<u>Grapes</u> buffed: <i>Fire</i>, applies <u>Burn</u> status (2d/1.5s, <i>Fire</i>, 3.1s duration)"
        },
        {
            UpgradeType.CannonShip,
            "<u>Grapes</u> buffed: +2d (3).\nReplaces <u>Dart</u> with <u>Cannonball</u> attack (1.3s (0.975 w/ 130), impact) that creates an explosion on hit (2d, 28p (35 w/ 031), <i>Explosion</i>) and <u>Frags</u> (1d, 1p (2 w/ 031), 8j, <i>Sharp</i>)."
        },
        {
            UpgradeType.MonkeyPirates,
            "<u>Cannonball</u> buffed: +1d (3), +5md, +2j (3). <u>Grapes</u> buffed: +2d (5), +2cd.\nAbility (45s cooldown): Immediately removes the strongest non-ZOMG/BAD Blimp, gaining full cash."
        },
        {
            UpgradeType.PirateLord,
            "All attacks: 50%s. <u>Grapes</u> buffed: +3d (8), +6d (8). <u>Burn</u> status buffed: +7d (9). <u>Cannonball</u> buffed: +3md (8). <u>Frags</u> buffed: +5d (6), +3md.\n" +
            "Ability (30s cooldown): now has six hooks and gains double cash; can use three hooks at once to take down a ZOMG."
        },

        { UpgradeType.LongRange, "+11r (71). <u>Darts</u>: +2p (3). <u>Grapes</u>: +1p (2), projectile speeds increased 25%." },
        { UpgradeType.CrowsNest, "Camo." },
        { UpgradeType.Merchantman, "$200 end of round income." },
        {
            UpgradeType.FavoredTrades,
            "<u>Dart</u> and <u>Grapes</u>: 50%s (0.5 for Darts, 0.75 for Grapes). <u>Burn</u> status buffed: +2d (4).\n+$300 end of round income ($500). Gains a buff: +4% sell price to anything in range; stackable up to 95% cap."
        },
        {
            UpgradeType.TradeEmpire,
            "+1d (2), +1cd, +1md, +$300 end of round income ($800). Gains a buff: +1d, +1cd, +1md, +$10n/+$20n income to up to 20 xx3/xx4 Buccaneers."
        },
    };
}