using UnityEngine;

namespace Lrw_Quiz
{
    public class Quiz : MonoBehaviour
    {
        private QuizButton O_QuizButton;
        private QuizButton X_QuizButton;

        [SerializeField] private Transform checkTarget;
        [field: SerializeField] public bool O_Button { get; private set; } = false;
        [field: SerializeField] public bool X_Button { get; private set; } = false;
        private void Awake()
        {
            QuizButton[] _quizButtons = GetComponentsInChildren<QuizButton>();
            O_QuizButton = _quizButtons[0];
            O_QuizButton.SetLayerMask(checkTarget);
            X_QuizButton = _quizButtons[1];
            X_QuizButton.SetLayerMask(checkTarget);



        }


    }
}

