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
    class Mysterycard : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            statModifiers.movementSpeed = 2.0f;
            gun.attackSpeed = 0.1f;
            gun.ammoReg = 0.1f;
            statModifiers.health = 0.9f;
            gun.bodyRecoil = 2.0f;
            statModifiers.respawns = 1;


            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            ModdingUtils.Utils.Cards.instance.AddCardToPlayer(player, ModdingUtils.Utils.Cards.instance.GetCardWithObjectName("Explosive bullet"), true, "TA", 0, 0);
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
        }

        protected override string GetTitle()
        {
            return "Mystery Card";
        }
        protected override string GetDescription()
        {
            return "??? who knows";
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
                    positive = true,
                    stat = "????",
                    amount = "???",
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "???",
                    amount = "???",
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "???",
                    amount = "???",
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "???",
                    amount = "???",
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