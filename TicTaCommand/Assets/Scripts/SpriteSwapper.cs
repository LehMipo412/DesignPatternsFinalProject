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
        var selectedButton = buttonsContainer.buttonArray[index];
        selectedButton.image.sprite = XSpriteToChange;
        selectedButton.interactable = false;
    }

    public void SwapImageToO(int index)
    {
        var selectedButton = buttonsContainer.buttonArray[index];
        selectedButton.image.sprite = OSpriteToChange;
        selectedButton.interactable = false;
    }



}
