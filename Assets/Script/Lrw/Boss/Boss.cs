using UnityEngine;

namespace Lrw_Boss
{
    public class Boss : MonoBehaviour
    {
        public BossBrain _bossBrain { get; private set; }
        [SerializeField] private BossAnimation _bossAnimation;
        [SerializeField] private GameObject BossAttackBulletPrefab;

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

