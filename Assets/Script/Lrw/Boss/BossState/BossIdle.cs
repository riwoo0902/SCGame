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

            int randomint = Random.Range(0, 5);
            if (randomint == 0 || randomint == 4)
            {
                _boss._bossBrain.ChangeBossState(BossStates.Quiz);
            }
            else if (randomint == 1)
            {
                _boss._bossBrain.ChangeBossState(BossStates.Attack1);
            }
            else if (randomint == 2)
            {
                Debug.Log("asddsasdasadsdsdaasdsadadsadasdads");
                _boss._bossBrain.ChangeBossState(BossStates.Attack2);
            }
            //else if (randomint == 3)
            //{
            //    _boss._bossBrain.ChangeBossState(BossStates.Attack3);
            //}
            //else if (randomint == 4)
            //{
            //    _boss._bossBrain.ChangeBossState(BossStates.Quiz);
            //}

        }

        public override void Update()
        {

        }

        public override void Exit()
        {
            Debug.Log("정지종료");
        }

    }
}