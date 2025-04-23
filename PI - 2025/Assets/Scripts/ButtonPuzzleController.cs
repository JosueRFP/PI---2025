using UnityEngine;

[RequireComponent (typeof(BoxCollider2D))]
public class ButtonPuzzleController : MonoBehaviour
{
    [SerializeField]  string correctOrder = "";
    [SerializeField] static string playerOrder = "";

    [SerializeField] static int digitsTotal = 0;

    [SerializeField] GameObject unlockObject, enemy;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
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
                Destroy(unlockObject);
            }
            else
            {
                playerOrder = "";
                digitsTotal = 0;
                enemy.SetActive(true);
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
