using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    [SerializeField] private int DieLoadSceneIndex;
    [SerializeField] private int WinLoadSceneIndex;


    public void WinLoadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(WinLoadSceneIndex);
    }
    public void DieLoadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(DieLoadSceneIndex);
        
    }

}
