using UnityEngine;

namespace Lrw_Quiz
{
    public class Quiz : MonoBehaviour
    {
        [SerializeField] private Transform checkTarget;
        [field: SerializeField] public bool O_Button { get; private set; } = false;
        [field: SerializeField] public bool X_Button { get; private set; } = false;
        public QuizButton O_QuizButton { get; private set; }
        public QuizButton X_QuizButton { get; private set; }

        private void Awake()
        {
            QuizButton[] _quizButtons = GetComponentsInChildren<QuizButton>();
            O_QuizButton = _quizButtons[0];
            O_QuizButton.SetLayerMask(checkTarget);
            X_QuizButton = _quizButtons[1];
            X_QuizButton.SetLayerMask(checkTarget);
        }

        private void Update()
        {
            O_Button = O_QuizButton.OnPlayer;
            X_Button = X_QuizButton.OnPlayer;
        }

    }
}

