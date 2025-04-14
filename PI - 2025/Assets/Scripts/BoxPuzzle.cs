using UnityEngine;

[RequireComponent (typeof(BoxCollider2D))]
public class BoxPuzzle : MonoBehaviour
{
    [SerializeField] GameObject box;
    [SerializeField] LayerMask mask;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mask = mask != 0 ? mask : 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
