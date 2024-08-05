using UnityEngine;

public class Judge : MonoBehaviour
{
    [SerializeField] TurnHandler turnHandler;


    public void CheckIfWinner()
    {
        var arrayRef = turnHandler._spriteSwapper.buttonsContainer.buttonArray;
        var xSpriteRef = turnHandler._spriteSwapper.XSpriteToChange;
        var oSpriteRef = turnHandler._spriteSwapper.OSpriteToChange;

        for (int i = 0; i < arrayRef.Length; i++)
        {
            if (i + 2 % 2 == 0)
            {
                if (arrayRef[i].image.sprite == xSpriteRef && arrayRef[i + 1].image.sprite == xSpriteRef && arrayRef[i + 2].image.sprite == xSpriteRef)
                {
                    turnHandler._textChanger.DeclareWinner(0);
                    arrayRef[i].image.color = Color.yellow;
                    arrayRef[i + 1].image.color = Color.yellow;
                    arrayRef[i + 2].image.color = Color.yellow;
                }
                if (arrayRef[i].image.sprite == oSpriteRef && arrayRef[i + 1].image.sprite == oSpriteRef && arrayRef[i + 2].image.sprite == oSpriteRef)
                {
                    turnHandler._textChanger.DeclareWinner(1);
                    arrayRef[i].image.color = Color.yellow;
                    arrayRef[i + 1].image.color = Color.yellow;
                    arrayRef[i + 2].image.color = Color.yellow;
                }
            }

        }
        if (arrayRef[0].image.sprite == xSpriteRef && arrayRef[4].image.sprite == xSpriteRef && arrayRef[8].image.sprite == xSpriteRef)
        {
            turnHandler._textChanger.DeclareWinner(0);
            arrayRef[0].image.color = Color.yellow;
            arrayRef[4].image.color = Color.yellow;
            arrayRef[8].image.color = Color.yellow;
        }
        if (arrayRef[2].image.sprite == xSpriteRef && arrayRef[4].image.sprite == xSpriteRef && arrayRef[6].image.sprite == xSpriteRef)
        {
            turnHandler._textChanger.DeclareWinner(0);
            arrayRef[2].image.color = Color.yellow;
            arrayRef[4].image.color = Color.yellow;
            arrayRef[6].image.color = Color.yellow;
        }
        if (arrayRef[0].image.sprite == oSpriteRef && arrayRef[4].image.sprite == oSpriteRef && arrayRef[8].image.sprite == oSpriteRef)
        {
            turnHandler._textChanger.DeclareWinner(1);
            arrayRef[0].image.color = Color.yellow;
            arrayRef[4].image.color = Color.yellow;
            arrayRef[8].image.color = Color.yellow;
        }
        if (arrayRef[2].image.sprite == oSpriteRef && arrayRef[4].image.sprite == oSpriteRef && arrayRef[6].image.sprite == oSpriteRef)
        {
            turnHandler._textChanger.DeclareWinner(1);
            arrayRef[2].image.color = Color.yellow;
            arrayRef[4].image.color = Color.yellow;
            arrayRef[6].image.color = Color.yellow;
        }

    }
}
