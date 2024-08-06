using UnityEngine;
using UnityEngine.UI;

public class BoardDeactivator : MonoBehaviour
{
    [SerializeField] ButtonArrayHandler _buttonArrayHandler;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void DeactivateAllBoardButtons()
    {
        foreach(Button tile in _buttonArrayHandler.buttonArray)
        {
            tile.interactable = false;
        }
    }
}
