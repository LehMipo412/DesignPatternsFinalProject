using UnityEngine;
using UnityEngine.UI;

public class SpriteSwapper : MonoBehaviour
{

    public ButtonArrayHandler buttonsContainer;
    public Sprite XSpriteToChange;
    public Sprite OSpriteToChange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SwapImageToX(int index)
    {
        var selectedButton = buttonsContainer.buttonArray[index];
        selectedButton.image.sprite = XSpriteToChange;
        selectedButton.image.color = Color.white;
        selectedButton.interactable = false;
    }

    public void SwapImageToO(int index)
    {
        var selectedButton = buttonsContainer.buttonArray[index];
        selectedButton.image.sprite = OSpriteToChange;
        selectedButton.image.color = Color.white;
        selectedButton.interactable = false;
    }

    public void MakeTileBlank(int index)
    {
        var selectedButton = buttonsContainer.buttonArray[index];
        selectedButton.image.sprite = default;
        selectedButton.image.color = Color.gray;
        selectedButton.interactable = true;

    }
}
