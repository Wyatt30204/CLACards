using BepInEx;
using RarityLib.Utils;
using class_addon.cards;
using UnboundLib;
using UnboundLib.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using RarityLib.Utils;

namespace classAddon
{
    [BepInDependency("root.rarity.lib", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch",
BepInDependency.DependencyFlags.HardDependency)]

    [BepInPlugin("CLA", "classAddon", "1.0.5")]

    [BepInProcess("Rounds.exe")]
    public class classAddon : BaseUnityPlugin
    {
        private const string ModId = "CLACards";
        private const string ModName = "classAddon";
        public const string Version = "1.0.5";
        public const string ModInitials = "CLAC";
        public static classAddon ins { get; private set; }
        void Awake()
        {

            var harmony = new Harmony(ModId);
            harmony.PatchAll();
            RarityUtils.AddRarity("Mythical", 0.09f, new UnityEngine.Color(255 / 255, 87 / 255, 51 / 255), new UnityEngine.Color(196 / 255, 80 / 255, 46 / 255));
        }

        void Start()    
        {
            CustomCard.BuildCard<Bestcard>();
            //CustomCard.BuildCard<pcoverclock>();
            //CustomCard.BuildCard<pcoverclockcardbad>((pcoverclockcardbadCardInfo) => ModdingUtils.Utils.Cards.instance.AddHiddenCard(pcoverclockcardbadCardInfo));
            //CustomCard.BuildCard<pcoverclockcardbad>((pcoverclockcardgoodCardInfo) => ModdingUtils.Utils.Cards.instance.AddHiddenCard(pcoverclockcardgoodCardInfo));
            CustomCard.BuildCard<blocktrouble>();
            CustomCard.BuildCard<tankcannon>();
            CustomCard.BuildCard<ihavethehighground>();
            CustomCard.BuildCard<Buff>();
            CustomCard.BuildCard<Nerf>();
            ins = this;
        }
    }

}