using UnityEngine;

public class PickupBehaviour : MonoBehaviour
{
    [SerializeField] EventsContainers _eventsContainers;
    private bool canEnter = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    public void JustkillMeAlready()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject != null)
        {
            
            if (collision.gameObject.CompareTag("Player") && !canEnter)
            {

                Debug.Log("I Should Notify The Subscribers");
                _eventsContainers.PickUpEvent.AddListener(JustkillMeAlready);
                canEnter = true;
                _eventsContainers.PickUpEvent.Invoke();


            }
        }
    }
}
