using UnityEngine;

namespace Lrw_Boss
{
    public class BossAttack2 : BossState
    {
        public BossAttack2(Boss boss) : base(boss)
        {

        }

        public override void Enter()
        {
            
        }

        public override void Update()
        {
            Debug.Log("������");
        }

        public override void Exit()
        {
            Debug.Log("��������");
        }

    }
}

