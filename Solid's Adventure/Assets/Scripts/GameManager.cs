using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    [SerializeField] public GameObject PlayerGO;
    //public List<GameObject> EnemyList = new List<GameObject>(); //use this in case we need to count enemies

    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }


}
