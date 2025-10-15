using UnityEngine;

namespace Lrw_Boss
{
    public class BossHide : BossState
    {
        public BossHide(Boss boss) : base(boss)
        {
            
        }

        public override void Enter()
        {
            Debug.Log("숨기시작");
        }

        public override void Update()
        {
            Debug.Log("숨기중");
        }

        public override void Exit()
        {
            Debug.Log("숨기종료");
        }

    }
}