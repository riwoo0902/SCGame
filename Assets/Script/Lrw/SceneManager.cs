using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    [SerializeField] private int DieLoadSceneIndex;
    [SerializeField] private int WinLoadSceneIndex;



    public static SceneManager _Instacne;
    private void Start()
    {
        if (_Instacne == null)
        {
            _Instacne = this;
        }
        UIManager._Instance.ActiveRoundText(true);
    }
    public void WinLoadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(WinLoadSceneIndex);
    }
    public void DieLoadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(DieLoadSceneIndex);

    }

}
