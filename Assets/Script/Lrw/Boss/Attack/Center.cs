using UnityEngine;

public class Center : MonoBehaviour
{

    private float rotateScale;
    private void FixedUpdate()
    {
        rotateScale += Time.fixedDeltaTime * 150;
        if (rotateScale >= 360)
            rotateScale = 0;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotateScale));
    }
}
