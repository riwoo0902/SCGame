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
            _boos = boos;
            CreateBossState(BossStates.Idle, new BossIdle(_boos));
            CreateBossState(BossStates.Attack1, new BossAttack1(_boos));
            CreateBossState(BossStates.Attack2, new BossAttack2(_boos));
            CreateBossState(BossStates.Attack3, new BossAttack3(_boos));
            CreateBossState(BossStates.Hide, new BossHide(_boos));
            CreateBossState(BossStates.Quiz, new BossQuiz(_boos));



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
        Quiz,Idle,Hide, Attack1, Attack2, Attack3
    }

}

