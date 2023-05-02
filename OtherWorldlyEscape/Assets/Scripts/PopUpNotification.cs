using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpNotification : MonoBehaviour
{
    public string message = "Default message";
    public GameObject popUpPanel;
    public GameObject notify;

    private float timer;

    void Start()
    {
        notify.SetActive(false);
        popUpPanel.SetActive(true);
        timer = 5f;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        
        if (timer <= 0f)
        {
            notify.SetActive(true);
            
            if (Input.anyKeyDown)
            {
                popUpPanel.SetActive(false);
            }
        }
    }

    
}