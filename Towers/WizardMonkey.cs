using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class WizardMonkeyTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.WizardMonkey;

    public override string TextValue => "<u>Bolt</u> attack (1d, 3p, 40r, 1.1s, <i>Energy</i>)";
}

public class WizardMonkeyUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {
            UpgradeType.GuidedMagic,
            "<u>Bolt</u>: homing. Ignores blocking obstacles. Wall of Fire can target a set spot."
        },
        {UpgradeType.ArcaneBlast, "<u>Bolt</u> buffed: +1d (2)."},
        {UpgradeType.ArcaneMastery, "+20r (60, 70 w/ 302), <u>Bolt</u> buffed: +1d (3), +4p (7, 12 w/ 301), 50%s (0.55). <u>Fireball</u> buffed: +4p (19)"},
        {UpgradeType.ArcaneSpike, "<u>Bolt</u> buffed: +3d (6), +10md, +1cd, 50%s (0.275), <u>Plasma</u>. <u>Fireball</u> buffed: +6md. <u>Wall of Fire</u> buffed: +2md."},
        {
            UpgradeType.Archmage,
            "All attacks: 50%s. <u>Bolt</u> buffed: +2d (8), +9md (19), +4p (11, 16 w/ 501), 50%s (0.1375). Gains <u>Dragons Breath</u> (2d, +8cd, 3p (5 w/ 501), 0.0675s, <i>Fire/i>) that applies <u>Burn</u> status (1d/1.5s, <i>Fire</i>, 3s duration) and <u>Shimmer</u> (0d, 500p, 75r zone (87.5 w/ 502), De-Camo) attacks. <u>Fireball</u>: +7d (9), +18md (24), +4p (23). <u>Wall of Fire</u>: +4md (6)."
        },

        {
            UpgradeType.Fireball,
            "Gains <u>Fireball</u> attack (1d, 2.2s, <i>Fire</i>) that creates an explosion (1d, 15p (20p w/ 011), <i>Explosion</i>) on damage."
        },
        {
            UpgradeType.WallOfFire,
            "Ever 5.5s creates <u>Wall of Fire</u> effect (1d, 10p (15 w/ 021), 20r, 0.15s, <i>Fire</i>, 4.5s (6.5s w/ 120) lifetime)."
        },
        {
            UpgradeType.DragonsBreath,
            "Gains <u>Dragons Breath</u> attack (2d, 3p (5p w/ 031), 0.135s, <i>Fire</i>) that applies <u>Burn</u> status (2d/1.5s, <i>Fire</i>, 3.1s duration). " +
            "Wall of Fire now .1s tick, 20p, created every 4.5s. <u>Fireball</u> buffed: 9d"
        },
        {
            UpgradeType.SummonPhoenix,
            "<u>Dragons Breath</u>: +1j (2). Ability (45s cooldown, 20s duration): Summons a <u>Phoenix</u> with <u>Flame</u> attack (5d, 8p, ∞r, 0.1s, <i>Fire</i>)."
        },
        {
            UpgradeType.WizardLordPhoenix,
            "<u>Dragons Breath</u> buffed: +13p (15, 17 w/ 051), +1j (3). <u>Fireball</u> buffed: 27d. <u>Burn</u> status buffed: 30d/1.5s, 15s duration. <u>Phoenix</u> is permanent. Ability (45s cooldown, 20s duration): Transforms into <u>Lava Phoenix</u> " +
            "with <u>Lava</u> attack (20d, 50p, ∞r, 0.1s, <i>Fire</i>) and <u>Meteor</u> attack (50d, 300p, ∞r, 1.0s, 8j, <u>Normal</i>)."
        },

        {UpgradeType.IntenseMagic, "<u>Bolt</u> buffed: +5p (7), faster projectile speed."},
        {UpgradeType.MonkeySense, "+10r (50). Camo."},
        {UpgradeType.Shimmer, "+10r (60). Gains <u>Shimmer</u> attack (0d, 500p, 2s, 75r zone, De-Camo)."},
        {
            "Necromancer: Unpopped Army",
            "Stores up to 500 pops within 70r in <u>Graveyard</u> for 2 rounds (pops worth 7-10 after round 80). " +
            "Gains <u>Reanimate</u> attack (1.5s (-10% per 100 current <u>Graveyard</u>), spawns 1-4 <u>Zombloons</u>, costs 1-10 <u>Graveyard</u> pops.). " +
            "<u>Zombloon</u>: 2d, 2p (+1 per pop used), <i>Normal</i>, 7s lifetime. All attacks: +1d per 200 current <u>Graveyard</u>."
        },
        {
            UpgradeType.PrinceOfDarkness,
            "All attacks: +1d per 300 current <u>Graveyard</u>. <u>Bolt</u> buffed: 25%s (0.275). <u>Shimmer</u> buffed: 50%s (1s). <u>Graveyard</u>: 3000 (3 rounds). " +
            "Gains <u>Reanimate Blimp</u> attack (3s; 20 pops for <u>ZMOAB</u> (40d (+1 per 300 current <u>Graveyard</u>), 20p, <i>Normal</i>, 15s), " +
            "or 50 pops for <u>ZBFB</u> (100d, 50p, <i>Normal</i>, 10s.) if Graveyard > 2000). ALL zombies have +3d."
        },
    };
}