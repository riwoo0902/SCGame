using UnityEngine;

[CreateAssetMenu(fileName = "QuizData", menuName = "Scriptable Objects/QuizData")]
public class QuizData : ScriptableObject
{
    [field : SerializeField] public string QuizText {  get; private set; }
    [field : SerializeField] public QuizValue QuizValue { get; private set; }

}
public enum QuizValue
{
    O,X
}
