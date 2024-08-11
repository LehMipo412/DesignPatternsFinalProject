using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float PlayerMaxHP;
    private float playerCurrentHP;

    private void Start()
    {
        playerCurrentHP = PlayerMaxHP;
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
}
