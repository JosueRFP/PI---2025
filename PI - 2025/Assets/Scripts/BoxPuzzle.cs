using UnityEngine;

[RequireComponent (typeof(BoxCollider2D))]
public class BoxPuzzle : MonoBehaviour
{
    [SerializeField] GameObject box, enemy;
    [SerializeField] LayerMask mask;
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
        if (collision.gameObject.CompareTag("Box"))
        {
            print("Colisão deu certo");
            Instantiate(enemy, transform);
        }
    }
}
