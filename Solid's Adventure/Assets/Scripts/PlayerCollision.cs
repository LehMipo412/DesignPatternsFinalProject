using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] EventsContainers _eventsContainers;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy collided with player");
            _eventsContainers.TakeDamageEvent.Invoke();
        }
    }
}
