using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;


public class Pause : MonoBehaviour
{
    [SerializeField] private Image pausePanel;
    [SerializeField] private Button startBtn;
    [SerializeField] private Button endBtn;

    private void Start()
    {
        pausePanel.gameObject.SetActive(false);
        startBtn.gameObject.SetActive(false);
        endBtn.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            pausePanel.gameObject.SetActive(true);
            startBtn.gameObject.SetActive(true);
            endBtn.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void StartBtn()
    {
        pausePanel.gameObject.SetActive(false);
        startBtn.gameObject.SetActive(false);
        endBtn.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void EndBtn()
    {
        pausePanel.gameObject.SetActive(false);
        startBtn.gameObject.SetActive(false);
        endBtn.gameObject.SetActive(false);
        Application.Quit();
        
    }
}
