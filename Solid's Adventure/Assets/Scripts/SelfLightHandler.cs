using UnityEngine;

public class SelfLightHandler : MonoBehaviour
{
    [SerializeField] Light playerLight;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ShineBrighter(float intensityModifier)
    {
        playerLight.intensity += intensityModifier;
    }
}
