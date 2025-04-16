using UnityEngine;
using TMPro;
using System.Collections;


public class DialogController : MonoBehaviour
{
    [SerializeField] float typeDelay;
    public TextMeshProUGUI textObj;

    public string fullText;
    
    void Start()
    {
        StartCoroutine(StartTyping());
    }

   
    IEnumerator StartTyping()
    {
        textObj.text = fullText;
        textObj.maxVisibleCharacters = 0;
        for (int i = 0; i < textObj.text.Length; i++) {
            textObj.maxVisibleCharacters = i;
            yield return new WaitForSeconds(typeDelay);

        }
    }

   
}
// video referencia https://www.youtube.com/watch?v=PsvhXlBlfp4&t=238s 3:20 a 5:51
