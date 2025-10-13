using UnityEngine;

namespace Lrw_Laser
{
    public class Laser : MonoBehaviour
    {
        [SerializeField] private HealthSystem targetHealthSystem;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(targetHealthSystem.TryGetComponent<HealthSystem>(out HealthSystem a))
            {

            }
        }

    }
}

