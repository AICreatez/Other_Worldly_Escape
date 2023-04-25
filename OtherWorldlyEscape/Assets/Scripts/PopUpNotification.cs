using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpNotification : MonoBehaviour
{
    public string message = "Default message";
    public float displayTime = 5f;
    public GameObject popUpPanel;
    public Button okButton;

    private float timer;

    void Start()
    {
        popUpPanel.SetActive(false);
        okButton.onClick.AddListener(DismissNotification);
    }

    void Update()
    {
        if (timer > 0f)
        {
            timer -= Time.deltaTime;

            if (timer <= 0f)
            {
                popUpPanel.SetActive(false);
            }
        }
    }

    public void DisplayNotification()
    {
        timer = displayTime;
        popUpPanel.SetActive(true);
        okButton.Select();
    }

    public void DismissNotification()
    {
        popUpPanel.SetActive(false);
        timer = 0f;
    }
}