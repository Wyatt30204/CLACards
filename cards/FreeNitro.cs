using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;
using System;
using System.Collections.Generic;
using Photon.Pun;
using Sonigon;
using ModdingUtils;
namespace class_addon.cards
{
    class FreeNitro : CustomCard
    {
        public float RemoveAfterSeconds { get; private set; }

        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {


            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            player.InvokeMethod("FullReset");
            RemoveAfterSeconds = 0;
            CardBarHandler.ReferenceEquals(player, this);
            ModdingUtils.Utils.Cards.instance.RemoveAllCardsFromPlayer(player, true);
            
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
        }





        protected override string GetTitle()
        {
            return "Free Nitro";
        }
        protected override string GetDescription()
        {
            return "Free nitro Lets Go";
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
                    stat = "???",
                    amount = "???",
               },
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