using System.Collections;
using UnityEngine;

namespace Lrw_Boss
{
    public class BossIdle : BossState
    {
        public BossIdle(Boss boss) : base(boss)
        {
            
        }

        public override void Enter()
        {
            Debug.Log("정지시작");
            _boss.StartCoroutine(ChangeState());
        }

        private IEnumerator ChangeState()
        {
            yield return new WaitForSeconds(5f);

            int randomint = Random.Range(0,4);
            if (randomint == 0)
            {
                _boss._bossBrain.ChangeBossState(BossStates.Hide);
            }
            else if (randomint == 1)
            {
                _boss._bossBrain.ChangeBossState(BossStates.Attack1);
            }
            else if (randomint == 2)
            {
                _boss._bossBrain.ChangeBossState(BossStates.Attack2);
            }
            else if (randomint == 3)
            {
                _boss._bossBrain.ChangeBossState(BossStates.Attack3);
            }
            
        }

        public override void Update()
        {
            Debug.Log("정지중");
        }

        public override void Exit()
        {
            Debug.Log("정지종료");
        }

    }
}