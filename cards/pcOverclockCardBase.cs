using UnboundLib;
using ModsPlus;
using UnboundLib.Networking;

namespace class_addon.cards
{
    public class pcOverclockCardBase : CustomEffectCard<PcOCEffect>
    {
        public override CardDetails Details => new CardDetails
        {
            Title = "PC Overclock",
            Description = "Overclock your pc, hopefully it doesnt go <color=ff0000>wrong</color>",
            ModName = "CLA",
            Rarity = CardInfo.Rarity.Uncommon,
            Stats = new []
            { 
                new CardInfoStat()
                {
                    stat = "Your PC",
                    amount = "Overclock",
                    positive = true
                },
                new CardInfoStat()
                {
                    stat="Your PC",
                    amount = "Overclock",
                    positive=false
                }
            }
            
           
        };
    }

     public class PcOCEffect : CardEffect
    {
        private int randomNumber = -1;

        void Awake()
        {
            if (player.data.view.IsMine)
            {
                randomNumber = UnityEngine.Random.Range(0, 1);
                NetworkingManager.RPC_Others(typeof(PcOCEffect), nameof(SyncRandomNumber), randomNumber, player.playerID);

                if (randomNumber == 0)
                {
                    // 50% chance of this
                    ModdingUtils.Utils.Cards.instance.AddCardToPlayer(player, ModdingUtils.Utils.Cards.instance.GetCardWithObjectName("PcOverclockCardBad"), true, "PC", 1f, 1f, true);
                }
                else
                {
                    // 50% chance of this
                    ModdingUtils.Utils.Cards.instance.AddCardToPlayer(player, ModdingUtils.Utils.Cards.instance.GetCardWithObjectName("PcOverclockCardGood"), true, "PC", 1f, 1f, true);
                }
            }
        }

        [UnboundRPC]
        public static void SyncRandomNumber(int randomNumber, int playerId)
        {
            var player = PlayerManager.instance.GetPlayerWithID(playerId);
            var rngEffect = player.GetComponent<PcOCEffect>();
            rngEffect.randomNumber = randomNumber;
        }
    }
}