using UnityEngine;

public class TurnHandler : MonoBehaviour
{
    [SerializeField] Judge _judge;
    private bool isXTurn = true;
    public SpriteSwapper _spriteSwapper;
    public TextChanger _textChanger;


    public void PlayAndPassTurn(int index)
    {
        if(isXTurn)
        {
            _spriteSwapper.SwapImageToX(index);
            isXTurn = false;
            _textChanger.PassTurnToO();
            _judge.CheckIfWinner();
        }
        else
        {
            _spriteSwapper.SwapImageToO(index);
            isXTurn = true;
            _textChanger.PassTurnToX();
            _judge.CheckIfWinner();
        }
    }
   
}
