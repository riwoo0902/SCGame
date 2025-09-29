using System.Collections.Generic;

namespace Lrw_Boss
{
    public class BossBrain
    {
        private BossState _currentBossState;
        private Dictionary<BossStates, BossState> _bossStateDic = new();
        private Boss _boos;

        public BossBrain(Boss boos)
        {
            CreateBossState(BossStates.Idle, new BossIdle(_boos));
            CreateBossState(BossStates.Attack, new BossAttack(_boos));
            CreateBossState(BossStates.Hide, new BossHide(_boos));




            StartBossState(BossStates.Idle);
        }

        private void CreateBossState(BossStates bossStates, BossState bossState)
        {
            _bossStateDic.Add(bossStates, bossState);
        }

        private void StartBossState(BossStates state)
        {
            _currentBossState = _bossStateDic[state];
            _currentBossState.Enter();
        }

        public void ChangeBossState(BossStates state)
        {
            _currentBossState.Exit();
            _currentBossState = _bossStateDic[state];
            _currentBossState.Enter();
        }
        public void UpData()
        {
            _currentBossState.Update();
        }

    }

    public enum BossStates
    {
        Attack,Speak,Idle,Hide
    }

}

