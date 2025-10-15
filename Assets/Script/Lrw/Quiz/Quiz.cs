using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Lrw_Quiz
{
    public class Quiz : MonoBehaviour
    {
        [SerializeField] private Transform checkTarget;
        [field: SerializeField] public bool O_Button { get; private set; } = false;
        [field: SerializeField] public bool X_Button { get; private set; } = false;
        public QuizButton O_QuizButton { get; private set; }
        public QuizButton X_QuizButton { get; private set; }
        [SerializeField] private QuizText _quizText;
        [SerializeField] private QuizData[] QuizDataSO;
        private int _quizCount = 0;
        [field: SerializeField] public GameObject BossLaserPrefab { get; private set; }
        public UnityEvent OnQuizEnd;
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

        public void QuizStart()
        {
            StartCoroutine(QuizStartt());
        }

        private IEnumerator QuizStartt()
        {
            _quizText.SetTextDada(QuizDataSO[_quizCount]);
            yield return new WaitForSeconds(5);
            GameEvent.quizStart?.Invoke();
            Instantiate(BossLaserPrefab).transform.position = new Vector3(QuizDataSO[_quizCount].QuizValue == QuizValue.O ? 2 : -2, 0.85f, 0);
            Instantiate(BossLaserPrefab).transform.position = new Vector3(-6, 0.85f, 0);
            Instantiate(BossLaserPrefab).transform.position = new Vector3(6, 0.85f, 0);

            _quizCount++;

            if (_quizCount == QuizDataSO.Length) StartCoroutine(EndWait());
        }
        private IEnumerator EndWait()
        {
            yield return new WaitForSeconds(5);
            OnQuizEnd?.Invoke();
            
        }

    }
}

