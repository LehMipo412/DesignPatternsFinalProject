using UnityEngine;
using TMPro;

public class TextChanger : MonoBehaviour
{
    [SerializeField] TMP_Text textToChange;
    private char winner;
    private const string XTurn = "The Player Commanding <color=red>X</color>'s Turn";
    private const string OTurn = "The Player Commanding <color=red>O</color>'s Turn";
    private string winnerDecleration = $"The Winner Is The Player Commanding: ";


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        PassTurnToX();
    }
    public void PassTurnToX()
    {
        textToChange.text = XTurn;
    }

    public void PassTurnToO()
    {
        textToChange.text = OTurn;
    }

    public void DeclareWinner(int winnerID)
    {
        if(winnerID == 0)
        {
            winner = 'X';
            winnerDecleration += winner;
        }
        if (winnerID == 1)
        {
            winner = 'O';
            winnerDecleration += winner;
        }
    }
}
