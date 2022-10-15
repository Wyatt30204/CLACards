using UnboundLib.Cards;
using UnityEngine;

namespace class_addon.cards
{
    class SelfObseverent : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            statModifiers.jump = 2f;
            statModifiers.regen = 15;
            statModifiers.health = 2.45f;
            block.autoBlock = true;
            block.additionalBlocks = 2;
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Edits values on player when card is selected
            ModdingUtils.Utils.Cards.instance.AddCardToPlayer(player, ModdingUtils.Utils.Cards.instance.GetCardWithObjectName("Empower"), false, null, 0, 0, false);
        }

        protected override string GetTitle()
        {
            return "Self Obseverent.";
        }
        protected override string GetDescription()
        {
            return "I Love My Self So Much";
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
                    stat = "jump heigth",
                    amount = "x2",
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Regen",
                    amount = "20",
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "health",
                    amount = "+145",
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "autiblock ",
                    amount = "true",
                },
                new CardInfoStat()
                {
                   positive = true,  
                   stat ="more Blocks",
                   amount ="2",

                }
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