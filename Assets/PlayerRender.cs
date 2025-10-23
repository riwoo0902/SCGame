using UnityEngine;

public class PlayerRender : MonoBehaviour
{
    [SerializeField] GameObject obect;
    public void PlayerDied()
    {
        GameObject a = Instantiate(obect, transform.position, Quaternion.identity);
        Destroy(a, 0.5f);
        Destroy(gameObject, 0.6f);
    }
}
