using System.Collections;
using UnityEngine;

namespace Lrw_Boss
{
    public class BossQuiz : BossState
    {
        public BossQuiz(Boss boss) : base(boss)
        {
            
        }

        public override void Enter()
        {
            Debug.Log("퀴즈시작");
            _boss.Quiz.gameObject.SetActive(true);
            _boss.StartCoroutine(ChangeState());
        }
        private IEnumerator ChangeState()
        {
            yield return new WaitForSeconds(5f);
            if(_boss.Quiz.O_Button)
                if (_boss.Quiz.O_Button)
                    yield return new WaitForSeconds(5f);
            _boss._bossBrain.ChangeBossState(BossStates.Idle);

        }

        public override void Update()
        {
            Debug.Log("퀴즈중");
        }

        public override void Exit()
        {
            Debug.Log("퀴즈종료");
            _boss.Quiz.gameObject.SetActive(false);
        }

    }
}