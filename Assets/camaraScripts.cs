using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class camaraScripts : MonoBehaviour
{
    [SerializeField] Volume volume;
    
    public void PlayerDiedEffect()
    {
        Vignette vignette;

        if (volume.profile.TryGet(out vignette))
        {
            vignette.active = true;
        }
    }
  
}
