using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    [SerializeField] public GameObject PlayerGO;
    [SerializeField] public PlayerUI PlayerHUD;
    [SerializeField] public PlayerHealth PlayerHP;
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

    public void EnemyHitPlayer()
    {
        Debug.Log("Enemy hit player");
        PlayerHP.TakeDamage(5);
    }

    public void OnPlayerTakeDamage(float newCurrentHP, float maxHP)
    {
        Debug.Log($"Player max HP = {maxHP}. Player current HP = {newCurrentHP}");
        PlayerHUD.DisplayHP(newCurrentHP / maxHP);
    }

    public void OnPlayerDeath()
    {
        //Game over
    }
}
