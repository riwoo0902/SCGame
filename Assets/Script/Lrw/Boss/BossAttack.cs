using UnityEngine;

namespace Lrw_Boss
{
    public class BossAttack : BossState
    {
        public BossAttack(Boss boss) : base(boss)
        {

        }

        public override void Enter()
        {
            Debug.Log("공격시작");
        }

        public override void Exit()
        {
            Debug.Log("공격종료");
        }

        public override void Update()
        {
            Debug.Log("공격중");
        }
    }
}

