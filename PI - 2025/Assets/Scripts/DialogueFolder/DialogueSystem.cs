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

        typeTxt.TypeFinished = OnTypeFinish;
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

    void OnTypeFinish()
    {
        states = States.WAITING;
    }

    

    void Waiting()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!finishedTxt)
            {
                Next();
            }
            else
            {
                states = States.DISABLE;
                currentText = 0;
                finishedTxt = false;
            }
        }
        

    }
    void Typing()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            typeTxt.Skip();
            states = States.WAITING;
        }
    }
}
