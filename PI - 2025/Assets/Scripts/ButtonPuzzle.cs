using UnityEngine;

[RequireComponent (typeof(BoxCollider2D))]
public class ButtonPuzzle : MonoBehaviour
{
    [SerializeField] static string correctOrder = "3312";
    [SerializeField] static string playerOrder = "";

    [SerializeField] static int digitsTotal = 0;
    [SerializeField] GameObject gate;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(playerOrder);

        if (digitsTotal == 4)
        {
            if (playerOrder == correctOrder)
            {
                print("Correto!");
                Instantiate(gate);

            }
            else
            {
                playerOrder = "";
                digitsTotal = 0;
                print("Incorreto");
                

            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerOrder += gameObject.name;
        digitsTotal += 1;
    }

}
// video referencia https://www.youtube.com/watch?v=o7aC62Nsv-M
