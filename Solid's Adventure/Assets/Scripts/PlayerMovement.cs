using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool isRunning;
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void HandleMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            isRunning = true;
           // Debug.Log("runing");
            transform.Translate(Vector3.forward * (Time.deltaTime * speed));
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
