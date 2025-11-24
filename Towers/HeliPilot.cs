using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class HeliPilotTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.HeliPilot;

    public override string TextValue => "<u>Darts</u> attack (1d, 3p, 40r, 0.56s, 2j, 40 flight speed, <i>Sharp</i>).";
}

public class HeliPilotUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.QuadDarts, "+2j (4)"},
        {
            UpgradeType.Pursuit,
            "Gains 'Pursuit' targeting (always flies towards a point slightly ahead of the first Bloon)."
        },
        {UpgradeType.RazorRotors, "Gains <u>Rotor</u> attack (2d, 10p, 35r zone, 0.45s, <i>Normal</i>)."},
        {
            UpgradeType.ApacheDartship,
            "<u>Darts</u> buffed: 75%s(0.4275). <u>Rotor</u> buffed: +2d (4), +10p (20).\nGains <u>Machine Gun</u> attack (1d, 7p, 0.05s, <i>Sharp</i>) and <u>Rocket</u> attack (2d, 40p, 1.0s, 84r, 4j, <i>Explosion</i>)."
        },
        {
            UpgradeType.ApachePrime,
            "<u>Dart</u> buffed: +5d (6), +20p (23), <i>Energy</i>. <u>Rotor</u> buffed: +4d (8), +20p (40). <u>Machine Gun</u> buffed: +4d (5), +4p (11), <i>Plasma</i>. <u>Rocket</u> buffed: +15md."
        },

        {UpgradeType.BiggerJets, "+30 Flight speed (70)."},
        {UpgradeType.IFR, "Camo."},
        {
            UpgradeType.Downdraft,
            "Gains <u>Downdraft</u> attack (0d, 0.2s (.16s w/ 032) 2p (ceramic use 2p)), that blows Bloon 32-150 units back, removes <u>Glued</u> and <u>Frozen</u> statuses."
        },
        {
            UpgradeType.SupportChinook,
            "+10 Flight speed (80). <u>Dart</u> buffed: +1d (2). <u>Downdraft</u> buffed: 25%s (0.15), +2p (4), minimum blowback 64 units.\nAbility (60s cooldown): Move a tower, except for: Aces, Helis, Handlers, Farms, Villages, Aircraft Carriers, Temples, Paragons, Terrain Powers, Rosalia, and map-exclusive towers.) Ability (90s cooldown): Drops $1550 and 10 lives."
        },
        {
            UpgradeType.SpecialPoperations,
            "+20 Flight speed (100). Ability buffed (15s cooldown): Move a tower. Ability buffed (60s cooldown): Drops $4500 and 25 lives.\nAbility (25s cooldown): deploy a Marine (30s lifetime) with a <u>Bullet</u> attack (6d, 20p, 0.05s, 50r, <i>Normal</i>)."
        },

        {UpgradeType.FasterDarts, "Darts travel 30% faster, +12.6r (54.6)."},
        {UpgradeType.FasterFiring, "All attacks buffed: 80%s."},
        {
            UpgradeType.MOABShove,
            "Gains <u>Shove</u> attack (0d, 1p) that sets non-BAD Blimp speed, negative speeds move affected blimps backwards (-30%,10%,61% total speed for MOAB,BFB,DDT/ZOMG (-41%,-1%,50% w/ 013).) <u>Rocket</u> attack: (2d, +2cd, +2md, 10p, 3s, ∞r)."
        },
        {
            UpgradeType.ComancheDefense,
            "<u>Dart</u> buffed: +1d (2). <u>Rocket</u> buffed: +1d (3), +10p (30), 1s. <u>Shove</u> buffed: -40%,0%,-11% total speed for MOAB,BFB,DDT/ZOMG (-51%,-11%,9% w/ 014).\n<u>Passive</u>: Summons 1, 2, 3 Mini-Comanches for 15s when a Bloon crosses 25%, 50%, 75% of the track" +
            "with <u>Mini Darts</u> attack (1d, 4p, 0.23s, 54.6r, 3j, <i>Sharp</i>) and <u>Mini Missile</u> attack (4d, +2cd, 60p, 3.0s, seeking, <i>Explosion</i>)."
        },
        {UpgradeType.ComancheCommander, "Flight speed +10 (50). <u>Dart</u> buffed: +2d (4). <u>Rocket</u> buffed: +10d (13), +4md (6).\n<u>Mini Darts</u> buffed: +2d (3). <u>Mini Missile</u> buffed: +13d (15), +8cd (10). Comanches are permanent."},
    };
}