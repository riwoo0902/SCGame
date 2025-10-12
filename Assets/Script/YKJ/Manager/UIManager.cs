using UnityEngine;
using DG.Tweening;
public class UIManager : MonoBehaviour
{

    [SerializeField] GameObject MenuWindow;
    private bool IsMenu = false;
    public void LodeScene()
    {

    }
    public void SetSetting()
    {
        if (IsMenu == false)
            MenuWindow.GetComponent<RectTransform>().DOAnchorPosX(0, 0.3f);
        else
            MenuWindow.GetComponent<RectTransform>().DOAnchorPosX(600, 0.3f);
        IsMenu = !IsMenu;
    }
    public void ExitGame() => Application.Quit();
}
