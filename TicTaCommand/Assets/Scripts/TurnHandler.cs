using UnityEngine;

public class TurnHandler : MonoBehaviour
{
    private bool isXTurn = true;
    [SerializeField] SpriteSwapper _spriteSwapper;
    [SerializeField] TextChanger _textChanger;


    public void PlayAndPassTurn(int index)
    {
        if(isXTurn)
        {
            _spriteSwapper.SwapImageToX(index);
            isXTurn = false;
            _textChanger.PassTurnToO();
        }
        else
        {
            _spriteSwapper.SwapImageToO(index);
            isXTurn = true;
            _textChanger.PassTurnToX();
        }
    }
   
}
