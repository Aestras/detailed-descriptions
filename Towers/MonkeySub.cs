using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class MonkeySubTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.MonkeySub;

    public override string TextValue => "<u>Dart</u> attack (1d, 2p, 0.7s, 42r, <i>Sharp</i>, homing)";
}

public class MonkeySubUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.LongerRange, "+10r (52)"},
        {
            UpgradeType.AdvancedIntel,
            "Can target anything in the primary attack range of any tower, including Camo detection."
        },
        {
            UpgradeType.SubmergeAndSupport,
            "Gains Submerge targeting option, replacing <u>Dart</u> with <u>Sonar</u> (0d, 100p (150 w/ 310), 1.5s (1.05s w/ 301), De-Camo)."
        },
        {
            UpgradeType.BloontoniumReactor,
            "<u>Sonar</u> buffed: 0.28s (0.196 w/ 401). While submerged, gains <u>Radioactive</u> attack (1d (+1ld w/ 420), 50p (100p w/ 410), 0.28s (0.196s w/ 410), <i>Shatter</i> (<i>Normal</i> with 420))\n" +
            "Water towers in range have 85% ability cooldowns."
        },
        {
            UpgradeType.Energizer,
            "<u>Sonar</u> buffed: 1000p. <u>Radioactive</u> buffed: +4d (5), 5cd, 1000p.\nWater towers in range have 60% ability cooldowns, all others 80%. Heroes in range get +50% XP."
        },

        {UpgradeType.BarbedDarts, "<u>Dart</u>: +3p (5)"},
        {UpgradeType.HeatTippedDarts, "<u>Dart</u>: <i>Normal</i>"},
        {
            UpgradeType.BallisticMissile,
            "+8r (50), gains <u>Missile</u> attack (3d, 3cd, 5md, 40p, 1s (0.875 w/ 031, <i>Explosion</i>). Ignores blocking obstacles."
        },
        {
            UpgradeType.FirstStrikeCapability,
            "Ability (60s cooldown): 10000 <i>Normal</i> damage to strongest Bloon, which can pierce blimp layers; additionally creates a (350d, 80p, 65r, <i>Normal</i>) explosion."
        },
        {
            UpgradeType.PreEmptiveStrike,
            "<u>Missile</u> buffed: +5d (10), +17cd (20), +10md (15), 50%s (0.5s, 0.4375 w/ 051). Ability buffed (45s cooldown): +10000d (20000), Explosion deals +650d (1000). Passive: Sends an <u>Assassin</u> (750d, <i>Normal</i>) at any Blimp that enters the map."
        },

        {UpgradeType.TwinGuns, "<u>Dart</u>: 50%s (0.375)."},
        {
            UpgradeType.AirburstDarts,
            "<u>Dart</u> is now an impact projectile, emits <u>Airbursts</u> on hit (1d, 2p, 3j, <i>Sharp</i>.)"
        },
        {UpgradeType.TripleGuns, "<u>Dart</u>: 66.66%s (0.251)."},
        {
            UpgradeType.ArmorPiercingDarts,
            "<u>Dart</u> buffed: +1d (2), +2md, +1fd.\n<u>Airbursts</u> buffed: +1md, +1fd, +3p (5)."
        },
        {
            UpgradeType.SubCommander,
            "50%s (0.125). <u>Airbursts</u> buffed: +2j (5). <u>Command</u> buff for all subs in range including self: all attacks double damage (except First Strike ability), +4p."
        },
    };
}