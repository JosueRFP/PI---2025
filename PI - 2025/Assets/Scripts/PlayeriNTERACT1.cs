using UnityEngine;

public class PlayeriNTERACT : MonoBehaviour
{
    public Transform interctPerson;
    DialogueSystem dialogueSystem;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        dialogueSystem = FindAnyObjectByType<DialogueSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(transform.position.x - interctPerson.position.x) < 2.0f)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                dialogueSystem.Next();
            }
        }
    }
}
