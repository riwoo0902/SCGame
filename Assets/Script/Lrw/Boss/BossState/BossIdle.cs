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