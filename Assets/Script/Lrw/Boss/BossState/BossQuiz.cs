using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Lrw_Boss
{
    public class BossQuiz : BossState
    {


        public UnityEvent StartQuiz;

        public UnityEvent EndQuizTime;
        public BossQuiz(Boss boss) : base(boss)
        {

        }

        public override void Enter()
        {
            _boss.Quiz.gameObject.SetActive(true);
            _boss.StartCoroutine(ChangeState());
            _boss.Quiz.QuizStart();
        }
        private IEnumerator ChangeState()
        {
            yield return new WaitForSeconds(10f);



            _boss._bossBrain.ChangeBossState(BossStates.Idle);


        }

        public override void Update()
        {
            Debug.Log("퀴즈중");
        }
        public override void Exit()
        {
          
            _boss.Quiz.gameObject.SetActive(false);
        }

    }
}