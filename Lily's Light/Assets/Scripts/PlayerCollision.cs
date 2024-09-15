using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public EventsContainers _eventsContainers;
    [SerializeField] HeartBeatManager _heartBeatManager;

    private void Start()
    {

        _eventsContainers.DemonGetsCloser.AddListener(ManageHeartbeatFromCollisionEnter);
    }

    public void ManageHeartbeatFromCollisionEnter()
    {
        _heartBeatManager.DemonGettingCloser();
    }
    public void ManageHeartbeatFromCollisionExit()
    {
        _heartBeatManager.EscapedDemon();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy collided with player");
            _eventsContainers.TakeDamageEvent.Invoke();
            
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            _eventsContainers.DemonGetsCloser.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            _eventsContainers.DemonGetsCloser.AddListener(ManageHeartbeatFromCollisionExit);
            _eventsContainers.DemonGetsCloser.Invoke();
            _eventsContainers.DemonGetsCloser.AddListener(ManageHeartbeatFromCollisionEnter);
        }
    }

}
