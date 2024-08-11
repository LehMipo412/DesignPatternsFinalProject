using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Pickup"))
        {

            Debug.Log("I Should Notify The Subscribers");

        }
        
    }
}
