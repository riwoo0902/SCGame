using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] GameObject MenuWindow;
    public void LodeScene()
    {

    }
    public void SetSetting()
    {
        if (MenuWindow.activeSelf == false)
            MenuWindow.SetActive(true);
        else
            MenuWindow.SetActive(false);
    }
}
