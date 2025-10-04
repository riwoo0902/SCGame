using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;


public class Pause : MonoBehaviour
{
    [SerializeField] private Image pausePanel;

    private void Start()
    {
        pausePanel.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            pausePanel.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
