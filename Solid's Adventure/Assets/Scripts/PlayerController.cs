using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerMovement _playerMovement;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _playerMovement.HandleMovement();
    }
}
