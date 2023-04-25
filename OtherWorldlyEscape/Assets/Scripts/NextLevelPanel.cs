using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class NextLevelPanel : MonoBehaviour
{
    public void LoadLevel()
    {
        // load the nextlevel
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
 
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
            LoadLevel();
    }
}