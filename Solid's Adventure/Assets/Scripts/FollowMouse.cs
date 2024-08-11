using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    private float xInputContainer;
    private float yInputContainer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerTransform);

        xInputContainer = Input.GetAxis("Mouse X");
        Debug.Log(xInputContainer);
        yInputContainer = Input.GetAxis("Mouse Y");

        var horizonAngle = transform.localEulerAngles.x;
        var verticalAngle = transform.localEulerAngles.y;

        if (yInputContainer > 180 && xInputContainer < 340)
        {
            xInputContainer = 340;

        }
        else if (yInputContainer < 180 && xInputContainer > 40)
        {
            xInputContainer = 40;
        }
        if (yInputContainer > 180 && xInputContainer < 340)
        {
            yInputContainer = 340;

        }
        else if (yInputContainer < 180 && xInputContainer > 40)
        {
            yInputContainer = 40;
        }

        transform.localEulerAngles += new Vector3(-yInputContainer*5, xInputContainer*5, 0);
        transform.position = playerTransform.position - transform.forward*5;

    }
}
