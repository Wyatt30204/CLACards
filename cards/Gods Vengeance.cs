using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnboundLib;
using ModsPlus;
using System.Collections;
using ModdingUtils.MonoBehaviours;
using BepInEx.Logging;

namespace classAddon
{
    public class GodsVengeance : CustomEffectCard<TestCardEffect>
    {
        public override CardDetails Details => new CardDetails
        {
            Title = "Gods vengeance"
        };
    }

    public class TestCardEffect : CardEffect
    {
        private float lastDamageTaken = 0f;
        private bool isActive = false;

        private ReversibleEffect damageBuff;

        protected override void Start()
        {
            base.Start();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            Destroy(damageBuff);
        }

        public override void OnTakeDamage(Vector2 damage, bool selfDamage)
        {
            if (selfDamage) return;
            lastDamageTaken = damage.magnitude / 55f;
            classAddon.LOGGER.LogInfo($"Took {lastDamageTaken} damage");
        }
        
        public override void OnBlock(BlockTrigger.BlockTriggerType blockTriggerType)
        {
            if (isActive || lastDamageTaken <= 0) return;
            isActive = true;

            damageBuff = player.gameObject.AddComponent<ReversibleEffect>();
            damageBuff.gunStatModifier.damage_add = lastDamageTaken;
            lastDamageTaken = 0;
        }

        public override IEnumerator OnShootCoroutine(GameObject projectile)
        {
            if (!isActive) yield break;
            yield return null;

            Destroy(damageBuff);
            isActive = false;
        }
    }
}