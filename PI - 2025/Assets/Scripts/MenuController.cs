using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject creditsPainel, levelPainel, controlPainel;
    
    public void Teleport(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void OpenCreditsPainel()
    {
        creditsPainel.SetActive(true);
    }

    public void CloseCreditsPainel()
    {
        creditsPainel.SetActive(false);
    }
    public void OpenLevelPainel() 
    {
    
    }
    public void OpenControlPainel() 
    {    
    
    }
}
