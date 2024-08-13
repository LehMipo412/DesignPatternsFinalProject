using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerMovement _playerMovement;
    
    


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
