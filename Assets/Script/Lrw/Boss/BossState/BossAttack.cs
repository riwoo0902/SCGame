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

