using UnityEngine;

namespace Lrw_Boss
{
    public class BossAttack3 : BossState
    {
        public BossAttack3(Boss boss) : base(boss)
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

