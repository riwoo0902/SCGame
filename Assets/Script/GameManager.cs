using UnityEngine;

public class GameManager : MonoBehaviour, IManager
{
    public static GameManager _Instance;


    private void Awake()
    {
        if (_Instance == null)
            _Instance = this;

        else
            Destroy(gameObject);

        DontDestroyOnLoad(_Instance);
        Init();
    }
    public void Init()
    {

    }

}
