using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;

namespace class_addon.cards
{
    class pcoverclockcardgood : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            statModifiers.health = 1.5f;
            gun.reloadTime = 1.5f;
            gun.projectileSpeed = 1.5f;
            statModifiers.movementSpeed = 1.5f;
            block.additionalBlocks = 2;
            gun.damage = 1.5f;
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
        }

        protected override string GetTitle()
        {
            return "Pc Overclock";
        }
        protected override string GetDescription()
        {
            return "GTX Overclocked? or fried";
        }
        protected override GameObject GetCardArt()
        {
            return null;
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Uncommon;
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Damgae",
                    amount = "+50%",
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Relaod Speed",
                    amount = "+50%",
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Projectile Speed",
                    amount = "+50%",
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Health",
                    amount = "+50%",
                },
                 new CardInfoStat()
                {
                    positive = true,
                    stat = "Movement Speed",
                    amount = "+50%",
                },
                  new CardInfoStat()
                {
                    positive = true,
                    stat = "Blocks",
                    amount = "+2",
                }
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.NatureBrown;
        }
        public override string GetModName()
        {
            return classAddon.classAddon.ModInitials;
        }
    }
}