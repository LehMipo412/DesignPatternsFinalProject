using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ViewModel : MonoBehaviour
{
    public ModelData Model;
    private int RunningIndex = 0;
    public TMP_Text ResultText;



    public void Roll()
    {
        int finalResult = 0;
        for (int i = 0; i < RunningIndex; i++)
        {
            int currentDieResult = Random.Range(1, Model.DiceList[i].Value);
            Model.diceButtonList[i].GetComponentInChildren<TMP_Text>().text = currentDieResult.ToString();
            finalResult += currentDieResult;
        }
        ResultText.text = "Result: " + finalResult;
    }

public void AddDie(int dieValue)
    {
        if (RunningIndex < Model.diceButtonList.Count)
        {
            Model.DiceList.Add(new Die(dieValue));
            Model.diceButtonList[RunningIndex].GetComponentInChildren<TMP_Text>().text = dieValue.ToString();

            switch (dieValue)
            {
                case 6:
                    Model.diceButtonList[RunningIndex].image.color = Color.green;
                    break;
                case 8:
                    Model.diceButtonList[RunningIndex].image.color = Color.red;
                    break;
                case 10:
                    Model.diceButtonList[RunningIndex].image.color = Color.cyan;
                    break;
                case 12:
                    Model.diceButtonList[RunningIndex].image.color = Color.grey;
                    break;
                case 20:
                    Model.diceButtonList[RunningIndex].image.color = Color.yellow;
                    break;
            }

            RunningIndex++;

        }
    }


    public void ClearAllChosen()
    {
        for (int i = 0; i < RunningIndex; i++)
        {
            Model.diceButtonList[i].GetComponentInChildren<TMP_Text>().text = "";
            Model.diceButtonList[i].image.color = Color.white;
        }
        RunningIndex = 0;
        Model.DiceList.Clear();
    }

   
}
