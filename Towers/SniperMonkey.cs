using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class SniperMonkeyTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.SniperMonkey;

    public override string TextValue => "<u>Bullet</u> attack (2d, 1p, 1.59s, ∞r, <i>Sharp</i>, impact)";
}

public class SniperMonkeyUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.FullMetalJacket, "<i>Normal</i>, <u>Bullet</u>: +2d (4).\n<u>Shrapnel</u>: +1d (2)."},
        {UpgradeType.LargeCalibre, "<u>Bullet</u>: +3d (7).\n<u>Shrapnel</u>: +1d (3)."},
        {UpgradeType.DeadlyPrecision, "<u>Bullet</u>: +13d (20), +15cd (35).\n<u>Shrapnel</u>: +1d (4)."},
        {UpgradeType.MaimMOAB, "+10d (30), applies <u>Stunned</u> to non-BAD Blimps (3s,1.5s,0.75s to MOAB,BFB,ZOMG/DDT. <u>Shrapnel</u>:+2d (6), <u>Stuns</u> for 66% duration)."},
        {
            UpgradeType.CrippleMOAB,
            "+110d (140), <u>Bullet</u> gains AOE (28d, 10p, 8r). Stun duration buffed: 7s,6s,3s,4s to MOAB,BFB,ZOMG,DDT and applies <u>Crippled</u> status (take +5d) 7s,6s,3s,4s,0.75s to MOAB,BFB,ZOMG,DDT,BAD/Boss.\n<u>Shrapnel</u>:+6d (12), +4p (6) <u>Stuns</u> and <u>Cripples</u> for 66% duration)."
        },

        {UpgradeType.NightVisionGoggles, "Camo.\nAll attacks buffed: +2 Camo damage"},
        {
            UpgradeType.ShrapnelShot,
            "On-hit effect: emits <u>Shrapnel</u> (1d, 2p, 5j, <u>Sharp</u>, 45° spread centred on the direction fired)"
        },
        {UpgradeType.BouncingBullet, "<u>Bullet</u>: 3p capped (no longer impact), jumps to targets within 40r (80r w/ 230) until pierce runs out."},
        {
            UpgradeType.SupplyDrop,
            "<u>Shrapnel</u> buffed: +3p (5). <u>Bullet</u> buffed: +3p (5), <i>Normal</i>. Ability (90s cooldown): Drops a crate worth $1100."
        },
        {
            UpgradeType.EliteSniper,
            "40%s (0.636s), buffs all other Snipers 75%s and provides Elite targeting (Near exit > Ceramics > Strong). Ability (90s cooldown): Drops a crate worth $3000."
        },

        {UpgradeType.FastFiring, "70%s (1.113s)"},
        {UpgradeType.EvenFasterFiring, "70%s (0.78s)"},
        {UpgradeType.SemiAutomatic, "33.33%s (0.26s)"},
        {UpgradeType.FullAutoRifle, "2md, 50%s (0.13s), <u>Shrapnel</u>: +1d (2)."},
        {
            UpgradeType.EliteDefender,
            "+2md (4md), 50%s (0.0649s), 1% faster per percent along track target is (max 100%). Passive (10s cooldown): Shoots 4× faster (0.0162) for 7s after leaking."
        },
    };
}