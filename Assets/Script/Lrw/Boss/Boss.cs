using UnityEngine;

namespace Lrw_Boss
{
    public class Boss : MonoBehaviour
    {
        private BossBrain _bossBrain;

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

