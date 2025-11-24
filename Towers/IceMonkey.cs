using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class IceMonkeyTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.IceMonkey;

    public override string TextValue =>
        "<u>Freeze</u> attack (1d, 40p, 2.4s, 20r, <i>Cold</i>) that applies <u>Frozen</u> status for 1.5s, 2 layers. Can be placed on water.";
}

public class IceMonkeyUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.Permafrost, "Applies <u>Permafrost</u> status (50% slow;, 2 layers)."},
        {UpgradeType.ColdSnap, "Camo, <u>Freeze</u>: <i>Glacier</i>."},
        {UpgradeType.IceShards, "+5r (25), applies <u>Shards</u> status (2d, 3p, 3j,, 2 layers, <i>Shatter</i> on pop), De-Camo, De-Grow."},
        {
            UpgradeType.Embrittlement,
            "<u>Shards</u> status buffed: De-Camo, De-Grow.\nApplies <u>Brittle</u> status (take +1d, removes Lead + Frozen immunities, 2s duration, 3 layers, can apply to Blimps)."
        },
        {
            UpgradeType.SuperBrittle,
            "+4d (5), +5cd, 50%s (1.2, 0.9 w/ 510), <i>Normal</i>.\n<u>Brittle</u> status buffed: take +4d, 3s duration, 6 layers (7 w/ 520). Blimps can receive <u>Permafrost</u> (25% slow). <u>Shards</u> status buffed: +8d (10), +3j (6)."
        },

        {UpgradeType.EnhancedFreeze, "75%s (1.8s), <u>Frozen</u> status now lasts 1.75s."},
        {UpgradeType.DeepFreeze, "+5p (45), <u>Frozen</u> status is passed down +1 (3) layer and lasts 2.2s."},
        {
            UpgradeType.ArcticWind,
            "Gains <u>Slow</u> aura (<i>Cold</i>, 40% slow). Land towers are placeable on any water in range."
        },
        {
            UpgradeType.Snowstorm, "+10r (30), Ability (30s cooldown): 1d to all non-white on screen, <i>Sharp</i>, " +
                                   "applies <u>Frozen</u> status to remaining Bloons for 6s, 3s for white, Blimp and camo, 140 applies <u>Permafrost</u>."
        },
        {
            UpgradeType.AbsoluteZero,
            "+255p (300), +10r (40), <u>Slow</u> effect is now 60%, <u>Frozen</u> status is passed down +5 (8) layers. Can target Blimps." +
            "Ability (25s cooldown): 1 damage and 10s <u>Frozen</u> status to everything; all Ice Monkeys gain 50%s buff for 10s."
        },

        {UpgradeType.LargerRadius, "+7r (27)"},
        {UpgradeType.ReFreeze, "<u>Freeze</u>: <i>Glacier</i>"},
        {
            UpgradeType.CryoCannon,
            "Replaces <u>Freeze</u> attack with <u>Ice Bomb</u> (1d, 40p, 1.2s (0.9s w/ 013), 46r, 20u radius, <i>Cold</i> (<i>Glacier</i> w/ 203)) that applies <u>Frozen</u> for 1.5s (1.75,2.2 w/ 013,023)."
        },
        {UpgradeType.Icicles, "+1d (2), +8md, 62.5%s (0.75, 0.5625 w/ 014), can target (but not <u>Freeze</u> Blimps). <u>Frozen</u> Bloons have <u>Icicles</u> (3d, 3p, <i>Shatter</i> (<i>Normal</i> w/ 204))."},
        {
            UpgradeType.IcicleImpale,
            "+40md (50), <i>Shatter</i> (<i>Normal</i> w/ 205). Blimps can be targeted: ZOMGSs are 50% slower, other non-BAD Blimps move at ZOMGs' original speed."
        },
    };
}