using UnityEngine;
using UnityEngine.UI;

public class SpriteSwapper : MonoBehaviour
{

    [SerializeField] ButtonArrayHandler buttonsContainer;
    [SerializeField] Sprite XSpriteToChange;
    [SerializeField] Sprite OSpriteToChange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SwapImageToX(int index)
    {
        buttonsContainer.buttonArray[index].image.sprite = XSpriteToChange;
    }

    public void SwapImageToO(int index)
    {
        buttonsContainer.buttonArray[index].image.sprite = OSpriteToChange;
    }



}
