using System.Collections;
using UnityEngine;

public class SelfLightHandler : MonoBehaviour
{
    [SerializeField] Light playerLight;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ShineBrighter(float intensityModifier)
    {
        StartCoroutine(ShineBrighterCorotine(intensityModifier));
    }


    IEnumerator ShineBrighterCorotine(float intensityModifier)
    {

        playerLight.intensity += intensityModifier;

        Mathf.Lerp(playerLight.range, playerLight.range+0.2f,1f);

        while(playerLight.range < playerLight.range + 0.2f)
        {
            Mathf.Lerp(playerLight.range, playerLight.range + 0.2f, 1f);
             new WaitForEndOfFrame();
            
        }

        yield return null;
    }
}
