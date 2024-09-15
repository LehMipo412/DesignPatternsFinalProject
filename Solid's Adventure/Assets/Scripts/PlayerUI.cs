using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Image playerHPTexture;

    public void DisplayHP(float percent)
    {
        if (playerHPTexture != null)
        {
            Debug.Log($"Player UI percentage = {percent}");
            playerHPTexture.fillAmount = percent;
        }
        else
        {
            Debug.Log("Missing HP UI Image");
        }
    }
}
