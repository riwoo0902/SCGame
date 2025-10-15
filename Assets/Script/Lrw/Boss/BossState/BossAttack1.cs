using System.Collections;
using UnityEngine;


namespace Lrw_Boss
{
    public class BossAttack1 : BossState
    {
        private float currentTime = 0;
        public BossAttack1(Boss boss) : base(boss)
        {
            
        }

        public override void Enter()
        {
            _boss.StartCoroutine(EndWait());
        }

        private IEnumerator EndWait()
        {
            yield return new WaitForSeconds(5);
            _boss._bossBrain.ChangeBossState(BossStates.Idle);
        }

        public override void Update()
        {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0)
            {
                currentTime += 0.15f;
                Object.Instantiate(_boss.BossAttackBulletPrefab).transform.position = new Vector3(UnityEngine.Random.Range(-6f, 6f), 1, 0);

            }
        }

        public override void Exit()
        {
            Debug.Log("공격종료");
        }

    }
}

