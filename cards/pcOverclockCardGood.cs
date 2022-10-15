﻿using class_addon.Effects;
using ModsPlus;
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
    class pcoverclockcardgood : CustomEffectCard<NoEffect>
    {
        public override CardDetails Details => new CardDetails
        {
            Title = "PC Overclock",
            Description = "GTX Overclocked? or fried",
            ModName = "CLA",
            Rarity = CardInfo.Rarity.Uncommon,
            Theme = CardThemeColor.CardThemeColorType.NatureBrown,
            Stats = new[]
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
            }
        };
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

    }
}