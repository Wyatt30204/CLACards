using BepInEx;
using BepInEx.Logging;
using class_addon.cards;
using UnboundLib.Cards;
using HarmonyLib;
using RarityLib.Utils;
using UnboundLib;

namespace classAddon
{
    [BepInDependency("root.rarity.lib", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]

    [BepInPlugin(ModInitials, ModId, Version)]

    [BepInProcess("Rounds.exe")]

    public class classAddon : BaseUnityPlugin
    {
        private const string ModId = "me.Wyatt.clacards";
        private const string ModName = "classAddon";
        public const string Version = "1.2.0";
        public const string ModInitials = "CLA";

        public static ManualLogSource LOGGER { get => ins.Logger; }
        public static classAddon ins { get; private set; }

        void Awake()
        {
            ins = this;
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
            RarityUtils.AddRarity("Mythical", 0.09f, new UnityEngine.Color(255 / 255, 87 / 255, 51 / 255), new UnityEngine.Color(196 / 255, 80 / 255, 46 / 255));
        }

        void Start()
        {
            CustomCard.BuildCard<GodsVengeance>();
            CustomCard.BuildCard<RefreshAmmo>();
            CustomCard.BuildCard<MiniTank>();
            CustomCard.BuildCard<SelfObseverent>();
            CustomCard.BuildCard<DoubleChance>();
            CustomCard.BuildCard<FreeNitro>();
            CustomCard.BuildCard<Mysterycard>();
            CustomCard.BuildCard<LowRider>();
            CustomCard.BuildCard<Newprocessor>();
            CustomCard.BuildCard<oldprocessor>();
            CustomCard.BuildCard<BestCard>();
            CustomCard.BuildCard<blocktrouble>();
            CustomCard.BuildCard<tankcannon>();
            CustomCard.BuildCard<HighGround>();
            CustomCard.BuildCard<Buff>();
            CustomCard.BuildCard<Nerf>();
            //CustomCard.BuildCard<pcOverclockCardBase>();
            //CustomCard.BuildCard<pcoverclockcardbad>((pcoverclockcardbadCardInfo) => ModdingUtils.Utils.Cards.instance.AddHiddenCard(pcoverclockcardbadCardInfo));
            //CustomCard.BuildCard<pcoverclockcardgood>((pcoverclockcardgoodCardInfo) => ModdingUtils.Utils.Cards.instance.AddHiddenCard(pcoverclockcardgoodCardInfo));
        }
    }

}