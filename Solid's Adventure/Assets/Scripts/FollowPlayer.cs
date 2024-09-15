using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    [SerializeField] GameObject playerGO;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3( playerGO.transform.position.x, transform.position.y, playerGO.transform.position.z);
        transform.eulerAngles = new Vector3(90, playerGO.transform.rotation.y, playerGO.transform.rotation.z);
    }
}
