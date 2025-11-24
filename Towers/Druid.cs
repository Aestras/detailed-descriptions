using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class DruidTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.Druid;

    public override string TextValue => "<u>Thorn</u> attack (1d, 1p, 1.1s, 35r, 5j, <i>Sharp</i>).";
}

public class DruidUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.HardThorns, "<u>Thorn</u> buffed: +1p (2), <i>Normal</i>"},
        {UpgradeType.HeartOfThunder, "Gains <u>Lightning</u> attack (2d, 5p, 2.3s, <i>Plasma</i>)."},
        {
            UpgradeType.DruidOfTheStorm,
            "Gains <u>Tornado</u> attack (0d, 24p (ceramic use 2p), 2.5s <i>Frigid</i>, ignores blocking obstacles.) that pushes back Bloons 100-200 units, removes <u>Glued</u> and <u>Frozen</u> statuses."
        },
        {
            UpgradeType.BallLightning,
            "<u>Lightning</u> buffed: +1d (3). <u>Tornado</u> buffed: +48p (60, no ceramic penalty), blows back 150-250 units.\nGains Ball Lightning attack (0d, 6.0s creation, 0.35s <u>Lightning</u> (forks 5 times (31 targets)), freezes any non-white Bloon for 4.5s through 4 layers, <i>Cold</i>, Ignores blocking obstacles.)."
        },
        {
            UpgradeType.Superstorm, "Camo. <u>Lightning</u> buffed: +27d (30). <u>Ball Lightning</u> <u>Lightning</u> buffed: +7d (10). " +
                                    "Gains <u>Superstorm</u> attack (120d, 200p (MOABs use 5p, DDTs 8p, BFBs 15p, ZOMGs 45p), 4.0s) that pushes back ~100-999 units and spawns <u>Ball Lightnings</u>. Bounces off map borders, ignores blocking obstacles."
        },

        {UpgradeType.ThornSwarm, "<u>Thorns</u> buffed: +3j (8)."},
        {UpgradeType.HeartOfOak, "+%p for each life above original life count (max +100%), all attacks gain on-hit effect: De-regrow."},
        {
            UpgradeType.DruidOfTheJungle,
            "Gains <u>Vine</u> attack (1.4s, ∞r) that targets strongest non-Blimp Bloon and destroys it. Drops <u>Brambles</u>: 1d, 20p, .3s, 4.5s lifespan (6 w/ 031), <i>Sharp</i> (<i>Normal</i> w/ 130)"
        },
        {
            UpgradeType.JunglesBounty,
            "+10r (45).<u>Brambles</u> buffed: +1 (2), +30p (40), 50%s (0.2), 9s lifespan (12 w/ 041).\n<u>Ability</u> (60s cooldown): Gains $320, plus $130 for every Banana Farm in range."
        },
        {
            UpgradeType.SpiritOfTheForest, "+$1000 end of round income. <u>Thorns</u> buffed: 20d. <u>Vine</u> buffed: 0.3s. " +
                                           "Gains <u>Bramble Zone</u> attack (within 50u (1d, 14cd, 14md, blue thorn/green stem), 50-100u (1d, +4cd, +4md, light green thorn/brown stem), beyond 100u (2d, +8cd, +8md, dark green thorn/brown stem), <i>Sharp</i> (<i>Normal</i> w/ 150)). " +
                                           "<u>Vine</u> buffed: 0.3s w/ 150. <u>Brambles</u> buffed: +4d (5), 50%s (0.1). Ability buffed: Gains $1280 +$130 per Farm, +25 lives."
        },

        {UpgradeType.DruidicReach, "+10r (45)."},
        {
            UpgradeType.HeartOfVengeance,
            "+x% speed, up to +50%, where x is 10 + lives below amount when upgrade was purchased, ignoring lives above the starting amount."
        },
        {
            UpgradeType.DruidOfWrath,
            "+y% speed (multiplicative), up to +100%, where y is 5% for every 10 damage dealt by this druid since it was last idle for more than 2s."
        },
        {
            UpgradeType.Poplust,
            "Gains a buff: +15% speed and pierce to other Druids in range; can stack (additively) up to 5 times."
        },
        {
            UpgradeType.AvatarOfWrath,
            "+3d (4), 50%s (0.55), +5r (50), +1d for every 3000 leak damage on screen, up to +30. (205 includes +d to <u>Lightning</u>)"
        },
    };
}