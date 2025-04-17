using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;


[Serializable]
public struct Dialogue
{
    public string name;
    [TextArea(5, 10)]
    public string text;
}
     



[CreateAssetMenu(fileName = "DialogueData", menuName = "ScriptableObject/TalkScript", order = 1)]
public class DialogueData : ScriptableObject 
{
    public List<Dialogue> talkScript;
    

    
}
// video refereencia para o dialogo https://www.youtube.com/watch?v=PsvhXlBlfp4&t=238s 
