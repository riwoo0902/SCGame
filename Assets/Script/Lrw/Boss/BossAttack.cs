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
            Debug.Log("���ݽ���");
        }

        public override void Exit()
        {
            Debug.Log("��������");
        }

        public override void Update()
        {
            Debug.Log("������");
        }
    }
}

