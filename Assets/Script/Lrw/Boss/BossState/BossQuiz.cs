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
            _boss.Quiz.QuizStart();
        }
        private IEnumerator ChangeState()
        {
            yield return new WaitForSeconds(8f);



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
            GameEvent.quizTimeEnd?.Invoke();
        }

    }
}