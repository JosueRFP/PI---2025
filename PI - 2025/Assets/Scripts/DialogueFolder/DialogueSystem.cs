using System.Linq;
using System.Net.NetworkInformation;
using UnityEngine;

public enum States
{
    DISABLE,
    WAITING,
    TYPING
}
public class DialogueSystem : MonoBehaviour
{
    public DialogueData dialogueData;
    
    int currentText = 0;
    bool finishedTxt = false;
    DialogController typeTxt;
   
    States states;

    private void Awake()
    {
        typeTxt = FindAnyObjectByType<DialogController>();
    }
    
    void Start()
    {
        states = States.DISABLE;
    }

    void Update()
    {
        if (states == States.DISABLE) return;

        switch (states) 
        { 
            case States.WAITING:
                Waiting();
                break;
                case States.TYPING:
                Typing();
                break;
        }
    }

    public void Next()
    {
        typeTxt.fullText = dialogueData.talkScript[currentText++].text;
        if(currentText == dialogueData.talkScript.Count) finishedTxt = true;
        typeTxt.StartTyping();
        states = States.TYPING;
    }

    void Typing()
    {

    } 

    void Waiting()
    {
        
    }
}
