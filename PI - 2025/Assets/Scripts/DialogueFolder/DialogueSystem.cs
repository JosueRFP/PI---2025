using System.Linq;
using System.Net.NetworkInformation;
using UnityEngine;

public enum States
{
    Disabele,
    Waiting,
    Typing
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
        states = States.Disabele;
    }

    void Update()
    {
        if (states == States.Disabele) return;

        switch (states) 
        { 
            case States.Waiting:
                Waiting();
                break;
                case States.Typing:
                Typing();
                break;
        }
    }

    public void Next()
    {
        typeTxt.fullText = dialogueData.talkScript[currentText++].text;
        if(currentText == dialogueData.talkScript.Count) finishedTxt = true;
        //typeTxt.StartTyping();
        states = States.Typing;
    }

    void Typing()
    {

    } 

    void Waiting()
    {
        
    }

    
}
