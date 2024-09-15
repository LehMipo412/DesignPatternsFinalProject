using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] EventsContainers _eventsContainers;
    [SerializeField] SelfLightHandler _lightHandler;
    [SerializeField] private float PlayerMaxHP;
    [SerializeField] float lightModifier;
    private float playerCurrentHP;

    private void Start()
    {
        playerCurrentHP = PlayerMaxHP;
        _eventsContainers.PickUpEvent.AddListener(RegainHope);

    }

    public void TakeDamage(float damage)
    {
        playerCurrentHP -= damage;
        Debug.Log($"Player current HP = {playerCurrentHP}");
        GameManager.Instance.OnPlayerTakeDamage(playerCurrentHP, PlayerMaxHP);
        if (playerCurrentHP <= 0)
        {
            playerCurrentHP = 0;
            GameManager.Instance.OnPlayerDeath();
        }
    }
    public void RegainHope()
    {
        _lightHandler.ShineBrighter(lightModifier);
    }
}
