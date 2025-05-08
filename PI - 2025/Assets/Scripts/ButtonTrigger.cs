using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    [SerializeField] string tagg;
    [SerializeField] GameObject gate;
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
        if (collision.gameObject.CompareTag(tagg))
        {
            gate.SetActive(false);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(tagg))
        {
            gate.SetActive(true);
        }
    }
}
