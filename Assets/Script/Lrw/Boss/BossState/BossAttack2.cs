using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace Lrw_Boss
{
    public class BossAttack2 : BossState
    {
        private GameObject center;
        private float currentTime = 0;

        public BossAttack2(Boss boss) : base(boss)
        {

        }
        public override void Enter()
        {
            _boss.StartCoroutine(EndWait());
            center = Object.Instantiate(_boss.BossCenter);
            center.transform.position = new Vector3(-5, -2, 0);
        }

        public override void Update()
        {

            currentTime -= Time.deltaTime;
            if (currentTime <= 0)
            {
                currentTime += 0.5f;
                GameObject attack = Object.Instantiate(_boss.BossAttackBulletPrefab);
                attack.transform.parent = center.transform;

            }
        }

        public override void Exit()
        {
            GameObject.Destroy(center);
        }
        private IEnumerator EndWait()
        {
            yield return new WaitForSeconds(10);
            _boss._bossBrain.ChangeBossState(BossStates.Idle);
        }

    }
}

