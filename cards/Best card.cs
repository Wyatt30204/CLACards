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
    class Bestcard : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            statModifiers.movementSpeed = 0.7f;
            gun.attackSpeed = 0.5f;
            gun.ammoReg = 5.0f;
            statModifiers.health = 2.0f;
            statModifiers.jump = 0.5f;
            statModifiers.numberOfJumps = 99999999;
            statModifiers.respawns = 1;
            gun.timeBetweenBullets = 0;
            gun.damage = 0.5f;
            

            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Edits values on player when card is selected
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
        }

        protected override string GetTitle()
        {
            return "Best Card";
        }
        protected override string GetDescription()
        {
            return "When you have had enough";
        }
        protected override GameObject GetCardArt()
        {
            return null;
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return RarityLib.Utils.RarityUtils.GetRarity("Mythical");
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Movement Speed",
                    amount = "-30%",
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Relaod Speed",
                    amount = "+100%",
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "ATKSPD",
                    amount = "+100%",
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Health",
                    amount = "+100%",
                },
               new CardInfoStat()
               {
                   positive = true,
                   stat = "fligt",
                   amount = "To The Moon"
               },
               new CardInfoStat()
               {
                   positive = true,
                   stat = "revive",
                   amount = "1",
               }, 
               new CardInfoStat()
               {
                   positive = true,
                   stat = "jump",
                   amount = "inf"
               },
               new CardInfoStat()
               {
                   positive = false,
                   stat = "damage",
                   amount = "-50%"
               }
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.PoisonGreen;
        }
        public override string GetModName()
        {
            return classAddon.classAddon.ModInitials;
        }
    }
}