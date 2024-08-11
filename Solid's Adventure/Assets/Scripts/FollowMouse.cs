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
        yInputContainer = Input.GetAxis("Mouse Y");

        var horizonAngle = transform.localEulerAngles.x;
        var verticalAngle = transform.localEulerAngles.y;

        if (horizonAngle > 180 && horizonAngle < 340)
        {
            horizonAngle = 340;

        }
        else if (horizonAngle < 180 && horizonAngle > 40)
        {
            horizonAngle = 40;
        }
        if (verticalAngle > 180 && verticalAngle < 340)
        {
            verticalAngle = 340;

        }
        else if (verticalAngle < 180 && verticalAngle > 40)
        {
            verticalAngle = 40;
        }

        transform.localEulerAngles = new Vector3(horizonAngle, verticalAngle, 0);
        transform.position = playerTransform.position - transform.forward;

    }
}
