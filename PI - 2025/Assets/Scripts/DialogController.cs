using UnityEngine;
using TMPro;
using System.Collections.Generic;
using UnityEngine.UI;

public class DialogController : MonoBehaviour
{
     public GameObject dialoguePainel;
    [SerializeField] RawImage npcImage;

    void Start()
    {
        npcImage.enabled = true;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject)
        {
            Instantiate(dialoguePainel);
        }
    }
}
