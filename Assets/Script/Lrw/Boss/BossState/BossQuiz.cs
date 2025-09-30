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
        }

        public override void Update()
        {
            Debug.Log("퀴즈중");
        }

        public override void Exit()
        {
            Debug.Log("퀴즈종료");
        }

    }
}