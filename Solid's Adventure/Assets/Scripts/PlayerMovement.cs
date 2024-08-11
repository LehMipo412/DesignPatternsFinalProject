using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    public bool isRunning;
    public float speed = 5;
    public Rigidbody playerRB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void HandleMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            isRunning = true;
            // Debug.Log("runing");
            transform.forward = new Vector3(0, 0, mainCamera.transform.eulerAngles.y);
            transform.eulerAngles = new Vector3(0, mainCamera.transform.eulerAngles.y, 0);
            transform.Translate(Vector3.forward * (Time.deltaTime * speed));
            //playerRB.MovePosition(Vector3.forward * (Time.deltaTime * speed));
            // playerRB.MovePosition(new Vector3(transform.position.x,transform.position.y,transform.forward.z+5f));
            //playerRB.Move((new Vector3(1,0,0) *  speed), new Quaternion(0, 0, mainCamera.transform.eulerAngles.y,0));
           // playerRB.linearVelocity = Vector3.forward *  speed;
           // Debug.Log(mainCamera.transform.forward);


        }
        if (Input.GetKey(KeyCode.A))
        {
            isRunning = true;
            transform.Translate(Vector3.left * (Time.deltaTime * speed));
        }

        if (Input.GetKey(KeyCode.S))
        {
            isRunning = true;
            transform.Translate(Vector3.back * (Time.deltaTime * speed));
            //transform.eulerAngles = mainCamera.transform.forward * -1 * (Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            isRunning = true;
            transform.Translate(Vector3.right * (Time.deltaTime * speed));
        }
        if (!Input.anyKey)
        {

            isRunning = false;
           // Debug.Log("Idle");
        }
    }
}
