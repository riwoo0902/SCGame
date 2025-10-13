using Lrw_Quiz;
using UnityEngine;

namespace Lrw_Boss
{
    public class Boss : MonoBehaviour
    {
        public BossBrain _bossBrain { get; private set; }
        [SerializeField] private BossAnimation _bossAnimation;
        [field:SerializeField] public GameObject BossAttackBulletPrefab { get; private set; }
        [field: SerializeField] public Quiz Quiz { get; private set; }
        [field: SerializeField] public GameObject BossLaserPrefab { get; private set; }
        private void Awake()
        {
            _bossBrain = new BossBrain(this);
        }

        private void Update()
        {
            _bossBrain.UpData();
        }


    }
}

