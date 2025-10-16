using UnityEngine;
using DG.Tweening;
using TMPro;
public class UIManager : MonoBehaviour
{
    public static UIManager _Instance;
    public TextMeshProUGUI RoundText;
    [SerializeField] Canvas canvas;
    public GameObject UIObject;
    private void Awake()
    {
        if (_Instance == null)
        {
            _Instance = this;
            DontDestroyOnLoad(_Instance);
            DontDestroyOnLoad(canvas);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void LodeScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        UIObject.SetActive(false);
    }
    public void ExitGame() => Application.Quit();
    public void ActiveRoundText(bool isActive)
    {
        RoundText.gameObject.SetActive(isActive);
    }
    public void SetRound(int value)
    {
        RoundText.text = "¶ó¿îµå: " + value.ToString();
        Debug.Log(value);
    }
}
