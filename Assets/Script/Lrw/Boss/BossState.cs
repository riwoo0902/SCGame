using UnityEngine;

namespace Lrw_Boss
{
    public abstract class BossState
    {
        protected Boss _boss;

        public BossState(Boss boss)
        {
            _boss = boss;
        }

        public abstract void Enter();
        
        public abstract void Update();

        public abstract void Exit();
        

    }
}