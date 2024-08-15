using UnityEngine;

public class HeartBeatManager : MonoBehaviour
{
    [SerializeField] AudioSource playerAS;
    [SerializeField] AudioClip calmHeartBeatAC;
    [SerializeField] AudioClip loudHeartBeatAC;
    //   [SerializeField] PlayerCollision playerCollision;
    private float calmTimer = 1.7f;
    private float loudTimer = 0.7f;
    private float currentTimer;
    private float timer = 0.3f;
    public int closeDemons = 0;
    private AudioClip currentACToPlay;
    void Start()
    {
        currentACToPlay = calmHeartBeatAC;
        currentTimer = calmTimer;
        //playerCollision._eventsContainers.DemonGetsCloser.AddListener(DemonGettingCloser);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <=0)
        {
            playerAS.PlayOneShot(currentACToPlay);
            timer = currentTimer;
        }
    }

    public void DemonGettingCloser()
    {
        closeDemons++;
        currentTimer = loudTimer;
        currentACToPlay = loudHeartBeatAC;

    }
    public void EscapedDemon()
    {
        closeDemons--;
        currentTimer = calmTimer;
        if (closeDemons == 0)
        {
            currentACToPlay = calmHeartBeatAC;
        }
        else
        {
            currentACToPlay = loudHeartBeatAC;
        }

    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        playerCollision._eventsContainers.DemonGetsCloser.Invoke();
    //        Debug.Log("The Demon Is Close...");
    //    }

    //}
    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        playerCollision._eventsContainers.DemonGetsCloser.AddListener(EscapedDemon);
    //        playerCollision._eventsContainers.DemonGetsCloser.Invoke();
    //    }
    //}
}
