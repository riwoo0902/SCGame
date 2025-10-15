using UnityEngine;

namespace Lrw_Quiz
{
    public class QuizButton : MonoBehaviour
    {
        public bool OnPlayer { get; private set; } = false;
        private Transform _checkTarget;
        public void SetLayerMask(Transform a)
        {
            _checkTarget = a;
        }

        private void FixedUpdate()
        {
            OnPlayer = false;
            foreach(Collider2D c in Physics2D.OverlapPointAll(_checkTarget.position))
            {
                if(c == gameObject.GetComponent<Collider2D>())
                {
                    OnPlayer = true; 
                    break;
                }
            }
            
        }
    }
}

