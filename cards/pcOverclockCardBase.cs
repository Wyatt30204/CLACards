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
    class pcoverclock : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Edits values on player when card is selected
            int randomNumber;
            System.Random random = new System.Random();
            randomNumber = random.Next(1, 3);
            if (randomNumber == 1)
            {
                // Give Bad
                ModdingUtils.Utils.Cards.instance.AddCardToPlayer(player, ModdingUtils.Utils.Cards.instance.GetCardWithName("Pc overload"), false, "GO", 0, 0);
            } else if (randomNumber == 2)

            {
                // Give Good
                ModdingUtils.Utils.Cards.instance.AddCardToPlayer(player, ModdingUtils.Utils.Cards.instance.GetCardWithName("Pc overclock"), false, "BA", 0, 0);
            }
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
        }

        protected override string GetTitle()
        {
            return "Pc Overclocking";
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