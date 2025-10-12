using UnityEngine;

namespace Lrw_Quiz
{
    public class Quiz : MonoBehaviour
    {
        private QuizButton[] _quizButtons;
        [SerializeField] private Transform checkTarget;
        [field: SerializeField] public bool O_Button { get; private set; } = false;
        [field: SerializeField] public bool X_Button { get; private set; } = false;
        private void Awake()
        {
            _quizButtons = GetComponentsInChildren<QuizButton>();
            foreach (QuizButton i in _quizButtons) i.SetLayerMask(checkTarget);
            
        }


    }
}

