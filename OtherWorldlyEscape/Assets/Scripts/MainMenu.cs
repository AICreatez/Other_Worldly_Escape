using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject levelPicker;
    
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
        levelPicker.SetActive(true);
    }

    public void HideLevels()
    {
        levelPicker.SetActive(false);
    }
}
