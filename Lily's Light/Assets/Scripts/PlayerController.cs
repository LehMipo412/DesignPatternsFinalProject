using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerMovement _playerMovement;
    //[SerializeField] PlayerCollision _playerCollision;
    //[SerializeField] HeartBeatManager _heartBeatManager;
    
    


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void FixedUpdate()
    {
        _playerMovement.HandleMovement();
    }
   
}
