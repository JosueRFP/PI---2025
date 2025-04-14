using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject creditsPainel, levelPainel, controlPainel;
    
    public void Teleport(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void OpenCreditsPainelBTN()
    {
        creditsPainel.SetActive(true);
    }

    public void CloseCreditsPainelBTN()
    {
        creditsPainel.SetActive(false);
    }

    public void OpenLevelPainelBTN() 
    {
        levelPainel.SetActive(true);
    }

    public void CloseLevelPainelBTN()
    {
        levelPainel.SetActive(false);
    }

    public void OpenControlPainelBTN() 
    {
        controlPainel.SetActive(true);
    }

    public void CloseControlPaineBTN()
    {
        controlPainel.SetActive(false);
    }

    public void QuitBTN()
    {
        Application.Quit();
        print("Saiu");
    }
}
