using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    public bool isRunning;
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void HandleMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            isRunning = true;
            // Debug.Log("runing");
            transform.eulerAngles = new Vector3(0, mainCamera.transform.eulerAngles.y, 0);
            transform.Translate(mainCamera.transform.forward * (Time.deltaTime * speed));
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            isRunning = true;
            transform.Translate(Vector3.left * (Time.deltaTime * speed));
        }

        if (Input.GetKey(KeyCode.S))
        {
            isRunning = true;
            transform.Translate(mainCamera.transform.forward* -1 * (Time.deltaTime * speed));
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
