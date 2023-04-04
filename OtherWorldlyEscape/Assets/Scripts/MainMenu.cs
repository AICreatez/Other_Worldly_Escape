using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject levelMenu;
    public GameObject mainMenu;
    
    public void PlayFirstLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ShowLevels()
    {
        levelMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void HideLevels()
    {
        levelMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
