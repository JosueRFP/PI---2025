using UnityEngine;

[RequireComponent (typeof(BoxCollider2D))]
public class ButtonPuzzleController : MonoBehaviour
{
    [SerializeField]  string correctOrder = "";
    [SerializeField] static string playerOrder = "";

    [SerializeField] static int digitsTotal = 0;
    [SerializeField] GameObject npc;

    public AudioClip audioClip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        audioClip = GetComponent<AudioClip>();
    }


    // Update is called once per frame
    void Update()
    {
        print(playerOrder);

        if (digitsTotal == 4)
        {
            if (playerOrder == correctOrder)
            {
                 Instantiate(npc);
                
            }
            else
            {
                playerOrder = "";
                digitsTotal = 0;
                
                

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
