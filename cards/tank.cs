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
    class tankcannon : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            statModifiers.movementSpeed = 0.5f;
          
            gun.ammoReg = 0.4f;
            statModifiers.health =1.5f;
            gun.damage = 3.0f;
            gun.projectileSpeed = 2.0f;
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            ModdingUtils.Utils.Cards.instance.AddCardToPlayer(player, ModdingUtils.Utils.Cards.instance.GetCardWithObjectName("Explosive bullet"), true, "EX", 0, 0);
            //Edits values on player when card is selected
        }
        
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
        }

        protected override string GetTitle()
        {
            return "tank cannon";
        }
        protected override string GetDescription()
        {
            return "speed is too powerful trade it in for remedy";
        }
        protected override GameObject GetCardArt()
        {
            return null;
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Rare;
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Movement Speed",
                    amount = "-80"
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Relaod Speed",
                    amount = "-30%",
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "ATKSPD",
                    amount = "-30%",
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Reload speed",
                    amount = "-30%",
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
                    stat = "dmg",
                    amount = "+50%",
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "projectile speed",
                    amount = "+100%",
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "exsplosive projectile",
                    amount = "Big boom",
                },
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.FirepowerYellow;
        }
        public override string GetModName()
        {
            return classAddon.classAddon.ModInitials;
        }
    }
}