using System;
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
    public Dialogue[] talkScript;

    
}
// video refereencia https://www.youtube.com/watch?v=PsvhXlBlfp4&t=238s 5:52 a 7:52
