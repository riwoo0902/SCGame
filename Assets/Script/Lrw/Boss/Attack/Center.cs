using UnityEngine;

public class Center : MonoBehaviour
{

    private float rotateScale;
    void Update()
    {
        rotateScale += Time.deltaTime * 65;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotateScale));
    }
}
