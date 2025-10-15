using UnityEngine;

namespace Lrw_Laser
{
    public class Laser : MonoBehaviour
    {
        private bool damage = false;

        public void Onendmas()
        {
            Destroy(gameObject);
        }

        public void CanDamage()
        {
            damage = true;
        }


        private void OnTriggerStay2D(Collider2D collision)
        {
            if (damage && collision.TryGetComponent(out HealthSystem a))
            {
                damage = false;
                a.Deal(1);
            }
        }
        

    }
}

