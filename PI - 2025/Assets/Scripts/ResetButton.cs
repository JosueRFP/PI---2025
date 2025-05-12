using UnityEngine;
using UnityEngine.UIElements;

public class ResetButton : MonoBehaviour
{
    [SerializeField] Transform objectOriginalPosition;
    [SerializeField] Transform objectPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject)
        {
            objectPosition.position = new Vector2(objectOriginalPosition.position.x, objectOriginalPosition.position.y);
        }
    }
}
