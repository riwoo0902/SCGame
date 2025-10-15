using UnityEngine;

namespace Lrw_Boss
{
    public class BossAttack1 : BossState
    {
        public BossAttack1(Boss boss) : base(boss)
        {
            
        }

        public override void Enter()
        {
            
        }

        public override void Update()
        {
            Debug.Log("공격중");
        }

        public override void Exit()
        {
            Debug.Log("공격종료");
        }

    }
}

