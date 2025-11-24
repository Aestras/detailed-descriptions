using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class NinjaMonkeyTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.NinjaMonkey;

    public override string TextValue => "<u>Shuriken</u> attack (1d, 2p, 40r, 0.62s, <i>Sharp</i>, Camo).";
}

public class NinjaMonkeyUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.NinjaDiscipline, "70%s (0.433)"},
        {UpgradeType.SharpShurikens, "<u>Shuriken</u> buffed: +2p (4)."},
        {UpgradeType.DoubleShot, "<u>Shuriken</u> buffed: +1j (2)."},
        {UpgradeType.Bloonjitsu, "<u>Shuriken</u> buffed: +3j (5)."},
        {UpgradeType.GrandmasterNinja, "+10r (50). <u>Shuriken</u> buffed: +1d (2), 50%s (0.217), +3j (8) (520 gains +4 camo damage, see Counter-Espionage description.)"},

        {
            UpgradeType.Distraction,
            "<u>Shuriken</u> gains on-damage effect: Bloons have a 15% chance (10%,30% for Caltrops,Flash Bomb) to be sent back 100-150 units (0.5x for Ceramics)."
        },
        {UpgradeType.CounterEspionage, "All attacks: gain De-camo on-damage effect, +2 camo damage (happens after De-Camo, so doesn't apply to anything but Phayze during Radar Jam."},
        {
            UpgradeType.ShinobiTactics,
            "Grants 92%s and +8%p (multiplicative) to all Ninjas in range (includes self), stacking up to 20 times. Max 18.87%s, 5.2p (10.4 w/ 2xx)."
        },
        {
            UpgradeType.BloonSabotage,
            "Ability (60s cooldown, 15s duration): All Bloons and Blimps move at half speed, including new spawns, but not children of Blimps."
        },
        {
            UpgradeType.GrandSaboteur,
            "Ability (60s cooldown, 30s duration): All Bloons and Blimps move at half speed, including new spawns, but not children of blimps; deals 25%d to new Blimps entering the map. x3x and x4x have +2md, +10r."
        },

        {UpgradeType.SeekingShuriken, "+7r (47), <u>Shurikens</u> gain homing."},
        {UpgradeType.Caltrops, "Every 3.9s (2.73 w/ 102), place a <u>Caltrop</u>: 1d, 6p, 35s (or 1 round) lifespan, <i>Sharp</i>."},
        {
            UpgradeType.FlashBomb,
            "<u>Shurikens</u> buffed: +4 <u>Stunned</u> damage, +2p. Every 4th Shuriken is replaced by <u>Flash Bomb</u> attack (3d, 30p, 40 blast radius, applies <u>Stunned</u> (1.3s) to Bloons), <i>Normal</i>."
        },
        {
            UpgradeType.StickyBomb,
            "Gains <u>Sticky Bomb</u> attack (4.5s, 3.15 w/ 104) which applies <u>Bomb</u> to strongest Blimp, dealing 500d <i>Normal</i> and (100d, 10p, 40r) AOE after 3s. <u>Shurikens</u>: +3d to Blimps with <u>Bomb</u>."
        },
        {
            UpgradeType.MasterBomber,
            "<u>Shurikens</u> buffed: +15 (19) <u>Stunned</u> damage, +16 (19) to Blimps with <u>Bomb</u>. <u>Flash Bomb</u> buffed: +7d (10), <u>Stunned</u> can now affect non-BAD Blimps for 0.25s.\n<u>Sticky Bomb</u> buffed: ∞r, 50%s (2.25, 1.575 w/ 105), also <u>Stunned</u> for 1s." +
            "<u>Bomb</u> status buffed: 3000d, 600d AOE"
        },
    };
}