using UnityEngine;

public class TurnHandler : MonoBehaviour
{
    [SerializeField] Judge _judge;
    private bool isXTurn = true;
    public SpriteSwapper _spriteSwapper;
    public TextChanger _textChanger;
    public int availableTiles = 9;


    public void PlayAndPassTurn(int index)
    {
        if(availableTiles==1)
        {

        }
        if(isXTurn)
        {
            _spriteSwapper.SwapImageToX(index);
            isXTurn = false;
            _textChanger.PassTurnToO();
            _judge.CheckIfWinner();
            availableTiles--;
        }
        else
        {
            _spriteSwapper.SwapImageToO(index);
            isXTurn = true;
            _textChanger.PassTurnToX();
            _judge.CheckIfWinner();
            availableTiles--;
        }
    }
   
}
