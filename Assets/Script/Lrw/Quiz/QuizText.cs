using System.Collections;
using TMPro;
using UnityEngine;

namespace Lrw_Quiz
{
    public class QuizText : MonoBehaviour
    {
        private TextMeshPro _textMeshPro;

        private void Awake()
        {
            _textMeshPro = GetComponent<TextMeshPro>();

        }

        public void SetTextDada(QuizData a)
        {
            StartCoroutine(ShowText(a.QuizText));
        }

        private IEnumerator ShowText(string a)
        {
            _textMeshPro.text = a;
            yield return new WaitForSeconds(5f);
            _textMeshPro.text = "";


        }


    }
}

