using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] public GameObject PlayerGO;
   // [SerializeField] GameObject pickupGO;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] public PlayerUI PlayerHUD;
    [SerializeField] EventsContainers _eventsContainers;
    [SerializeField] public PlayerHealth PlayerHP;
    private int score = 0;
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
        scoreText.text = $"Score: {score}";

        _eventsContainers.PickUpEvent.AddListener(UpdateScore);
        _eventsContainers.TakeDamageEvent.AddListener(EnemyHitPlayer);
        


    }

    public void Foo()
    {
        Debug.Log("FOOOOO");
    }
    public void UpdateScore()
    {

        score += 10;
        scoreText.text = $"Score: {score}";
    }

    //public void DestroyPickup()
    //{
    //    Destroy(pickupGO);
    //}

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
