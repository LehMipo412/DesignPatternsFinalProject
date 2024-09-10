using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelData : MonoBehaviour
{
    public List<Button> diceButtonList;
    public List<Die> DiceList;



    private void Start()
    {
        DiceList = new List<Die>();
    }
}

