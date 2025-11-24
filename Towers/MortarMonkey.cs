using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class MortarMonkeyTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.MortarMonkey;

    public override string TextValue =>
        "<u>Shell</u> attack (2.0s, ∞r) creates <u>Explosion</u> effect (2d, 25p, <i>Explosion</i> type, 20u blast radius), 18u spread.";
}

public class MortarMonkeyUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        { UpgradeType.BiggerBlast, "+8p (28), +8 blast radius (28)" },
        { UpgradeType.BloonBuster, "+1d (3)" },
        {
            UpgradeType.Shockwave,
            "+10 blast radius (38), <u>Shell</u> also creates: <u>Shockwave</u> (1d, 45p, 57u blast radius, <i>Explosion</i>) that applies <u>Stunned</u> status in a 19u blast radius for 0.5s. <u>Burn</u> status buffed: 2d/0.625s."
        },
        { UpgradeType.TheBigOne, "All attacks buffed: 85p. <u>Shell</u> buffed: +7d (10), +2cd, +20 blast radius (58).\n<u>Shockwave</u> buffed: +1d (2), +2cd, blast radius +30 (87) <i>Normal</i>. <u>Stunned</u> buffed: blast radius +10 (29), duration 0.75s. <u>Burn</u> status buffed: +10d (12)." },
        {
            UpgradeType.TheBiggestOne,
            "All attacks buffed: 200p. <u>Explosion</u> buffed: +15d (25), +28cd (30), +30md, +16 blast radius (74).\n<u>Shockwave</u> buffed: +18cd (20), +24 blast radius (111). <u>Stunned</u> buffed: blast radius +8 (37), can stun Blimps (MOAB 0.5s, BFB/DDT 0.3s, ZOMG 0.1s). <u>Burn</u> status buffed: +53d (65)."
        },

        { UpgradeType.MortarFasterReload, "75%s (1.5)" },
        { UpgradeType.MortarRapidReload, "72%s (1.08)" },
        { UpgradeType.HeavyShells, "66%s (0.81), +3cd, +1md, +1fd, +1ld, +2 <u>Stunned</u> damage, <i>Normal</i>. <u>Burn</u> status buffed: +3d (4)." },
        {
            UpgradeType.ArtilleryBattery,
            "33%s (0.27). <u>Burn</u> status buffed: +2d (6). Ability (60s cooldown): 4x attack rate ((0.0675)) and +15% blast radius for 8s."
        },
        {
            UpgradeType.PopAndAwe,
            "25%s (0.0675), +6 <u>Stunned</u> damage (8) +3 blast radius (23). <u>Burn</u> status buffed: +14d (20), duration 7.5s.\nGrants all xx4 Mortars +1 BAD/Boss damage. Ability (60s cooldown): Every second for the next 8 seconds, hits everything on screen for 20d and a 1s stun (applies <u>Burn</u> (36d/1.25s, 7.5s duration) w/ 052."
        },

        { UpgradeType.IncreasedAccuracy, "-10u (8) spread." },
        {
            UpgradeType.BurnyStuff,
            "On-damage effect: apply <u>Burn</u> status (1d/1.25s), <i>Fire</i>, 3.75s duration)."
        },
        { UpgradeType.SignalFlare, "Camo. <u>Shell</u> also creates: <u>Flare</u> (52r (72.8 w/ 103), 50p (90 w/ 103)), De-Camo." },
        { UpgradeType.ShatteringShells, "<u>Shell</u> buffed: De-Grow, De-Fortify up to BFB. <u>Burn</u> status buffed: +4d (5, 8 2/ 204), +20md (25 w/ 204)." },
        {
            UpgradeType.Blooncineration,
            "<u>Shell</u> buffed: De-Fortify up to DDT. <u>Burn</u> status buffed: 5d/0.75s (8 w/ 205), +75md (90, 142 w/ 205). Gains <u>Firewall</u> attack: (1d (3 w/ 205), 20p (36 w/ 105), 15r (21 w/ 105), rehits every 0.1s, duration 4.5s)."
        },
    };
}