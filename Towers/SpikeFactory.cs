using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class SpikeFactoryTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.SpikeFactory;

    public override string TextValue =>
        "<u>Spikes</u> attack (1d, 5p, 1.75s, 34r, targets track, 50s or end of round lifespan, <i>Sharp</i>).";
}

public class SpikeFactoryUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.BiggerStacks, "+5p (10)"},
        {UpgradeType.WhiteHotSpikes, "Spikes: <i>Normal</i>."},
        {UpgradeType.SpikedBalls, "+1d (2), +3cd, +1fd, +1p (11)."},
        {
            UpgradeType.SpikedMines,
            "+7p, (18), +3cd (6), +2fd (3). Creates an <u>Explosion</u> (10d, +2cd, +3fd, 30p, 30 (40 w/ 401) blast radius, <i>Explosion</i>) that applies <u>Burn</u> status (10d/2s, <i>Fire</i>, 6s duration) when spikes expire."
        },
        {
            UpgradeType.SuperMines,
            "200%s (3.5s, 2.8 w/ 510). Spikes get +48d (50), +24cd (30), +12fd (15). <u>Explosion</u> buffed: 1000d, +498cd (500), +247fd (250), +30p (60), +70 (100, 133.6 w/ 501) blast radius. <i>Normal</i>.\n" +
            "Each Spike of each mine makes a smaller <u>Mini-Explosion</u> (20d, 10cd, 5fd, 30p, 30 (40 w/ 501) blast radius, <i>Normal</i>). <u>Burn</u> buffed: 2500d."
        },

        {UpgradeType.FasterProduction, "80%s (1.4)"},
        {UpgradeType.EvenFasterProduction, "70%s (0.98)"},
        {UpgradeType.MOABSHREDR, "+7md (40 total per pile, 80 w/ 130)."},
        {
            UpgradeType.SpikeStorm,
            "Ability (40s cooldown): For 2s, places 4 <u>Spikes</u> every .04s randomly on track, total 200 piles. These <u>Spikes</u> last 9-11s (18-22s w/ 041).\n042 causes <u>Spikes</u> to only land on active tracks of the current round."
        },
        {
            UpgradeType.CarpetOfSpikes,
            "<u>Spikes</u> buffed: +2d (3), +7md, +5p (10, 15 w/ 150) +16r (50, 58 w/051), .49s.\nPassive (15s cooldown): Same as activated ability. Ability <u>Spikes</u> last 18-22s (36-44s w/ 051)."
        },

        {UpgradeType.LongReach, "+8r (42), 100s lifespan."},
        {
            UpgradeType.DirectedSpikes,
            "Gains extra targeting options: close, set target, automatic (attempts to directly target the first Bloon), and smart (whichever track Bloons are closest to reaching the exit, closest point to the exit).\nPassive (1 round cooldown): 4× faster (0.55s) for 2.5s."
        },
        {UpgradeType.LongLifeSpikes, "140s or end of 2 rounds lifespan."},
        {UpgradeType.DeadlySpikes, "+2d (3), 140s or end of 3 round lifespan."},
        {UpgradeType.PermaSpike, "+7d (10), +45p (50, 85 w/ 105), 6.06s (4.85,3.64 w/ 015,025), 300s or end of 3 round lifespan."},
    };
}