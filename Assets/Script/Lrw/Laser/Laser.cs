using System;
using UnityEngine;

namespace Lrw_Laser
{
    public class Laser : MonoBehaviour
    {
        public Action OnEnd;

        private void Awake()
        {
            OnEnd += Onendmas;
        }
        public void Onendmas()
        {
            Destroy(gameObject);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.TryGetComponent(out HealthSystem a))
            {
                a.Deal(1);
            }
        }

    }
}

