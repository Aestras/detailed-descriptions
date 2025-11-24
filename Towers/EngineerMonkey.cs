using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class EngineerMonkeyTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.EngineerMonkey;

    public override string TextValue => "<u>Nail</u> attack (1d, 3p, 0.7s, 40r, <i>Sharp</i>).";
}

public class EngineerMonkeyUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {
            UpgradeType.SentryGun,
            "Every 10s, place a <u>Sentry</u> that lasts 25s and has <u>Sentry Nail</u> attack (1d, 2p (3p w/ 101), 0.95s, 45r (49r w/ 110), <i>Sharp</i> (<i>Shatter</i> w/ 101))."
        },
        {UpgradeType.FasterEngineering, "<u>Sentries</u> built every 5s."},
        {UpgradeType.Sprockets, "<u>Nail</u> and <u>Sentry Nail</u> buffed: 50%s. Applies <u>Pinned</u> with 302."},
        {
            UpgradeType.SentryExpert,
            "<u>Crushing Sentry</u> has <u>Spiked-ball</u> attack (2d, 4cd, 22p, 50r, 1.2s, <i>Shatter</i>). " +
            "<u>Boom Sentry</u> has a <u>Bomb</u> attack (4d, 30p, 50r, 1s, 18 blast radius, <i>Explosion</i>). " +
            "<u>Cold Sentry</u> has a <u>Ice-ball</u> attack (1d, 24p, 50r, 1.5s, <i>Cold</i>) that applies <u>Frozen</u>/<u>Permafrost</u> status for 1.5s through 2 layers. " +
            "<u>Energy Sentry</u> has a <u>Laser</u> attack (2d, 2md, 8p, 50r, 0.57s, <i>Energy</i>)."
        },
        {
            UpgradeType.SentryParagon,
            "Places <u>Champion Sentries</u> with <u>Plasma</u> attack (3d, 5p (10 w/ 501), 50r, 0.06s, <i>Plasma</i>) that self-destruct for (100d, 50p (75 w/ 501), <i>Plasma</i>)."
        },

        {UpgradeType.LargerServiceArea, "+20r (60), +4r to <u>Sentries</u>, allows point targeting of <u>Traps</u>."},
        {UpgradeType.Deconstruction, "All attacks buffed: +1md, +1fd. <u>Traps</u> De-fortify."},
        {
            UpgradeType.CleansingFoam,
            "Every 2s (1s w/ 230), places <u>Foam</u> (0d, 1 ld, 10p (15p w/ 230), <i>Normal</i>, 8.5s lifetime, De-fortifies Lead, De-camo, De-grow, applies <u>Slow</u> to non-Blimps by 0.5x speed for 1 second with 032\nGrants De-camo, De-grow, De-fortify Lead, 1ld to <u>Sentries</u> with 230.)."
        },
        {
            UpgradeType.Overclock,
            "<u>Nail</u> buffed: +12p (15). <u>Foam</u> buffed: +4p (14).\nAbility (45s cooldown): Chosen tower attacks 1.667× faster for the next Xs (X being 30s,45s,60s for Tier 5, Tier 4, and Tier 3(and below or heroes))\n" +
            "Overclocked farms give more income; Villages have +25%r."
        },
        {
            UpgradeType.Ultraboost,
            "<u>Nail</u> buffed: +15p (30). <u>Foam</u> buffed: +10p (24).\nAbility buffed (35s cooldown): When Overclock is applied, the tower gains an additional permanent 4% speed (2.5%r for Villages) buff, which stacks additively up to 10 times."
        },

        {UpgradeType.OversizeNails, "<u>Nail</u> buffed: +5p (8), <i>Shatter</i>.\n<u>Sentries</u> gain +1p(+50%p w/ 401, +5p w/ 501), <i>Shatter</i>. Foam gains +(5,7,12 w/ 031,041,051)p."},
        {
            UpgradeType.Pin,
            "<u>Nail</u> buffed: Applies <u>Pinned</u> status (1s duration, stun, Ceramic and higher are immune).\n032 <u>Foam</u> can <u>Slow</u> non-Blimps (0.5x speed for 1 second). 302 <u>Sentries</u> can Pin."
        },
        {UpgradeType.DoubleGun, "50%s (0.35).\n<u>Sentries</u> gain +1j."},
        {
            UpgradeType.BloonTrap,
            "Places <u>Traps</u> (500 RBE, +1 cash modifier, 100r collection). Places new <u>Traps</u> 12s (9s w/ 204) cooldown, minimum of 2.8s (2.1s w/ 204). 024 De-fortifies before trapping."
        },
        {UpgradeType.XXXLTrap, "<u>Trap</u> buffed: 10,000 RBE, +2 cash modifier, can trap blimps below BAD, 4.6s (2.3s w/ 205) cooldown, minimum of 2.1s (1.4s w/ 205)."},
    };
}