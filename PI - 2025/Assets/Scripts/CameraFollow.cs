using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x, target.transform.position.y, transform.position.z);
    }
}
