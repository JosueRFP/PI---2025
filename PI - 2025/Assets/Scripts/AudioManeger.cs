using UnityEngine;

public class AudioManeger : MonoBehaviour
{
    [SerializeField] AudioClip soundToGo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        soundToGo = GetComponent<AudioClip>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
