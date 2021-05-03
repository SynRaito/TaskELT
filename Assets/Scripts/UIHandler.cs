using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UIHandler : MonoBehaviour
{
    public GameObject UIPanel;

    bool isShown;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    public void ShowHideUI()
    {
        if (!isShown)
        {
            UIPanel.SetActive(true);
            isShown = true;
        }
        else
        {
            UIPanel.GetComponent<QuestionType1>().ClearAll();
            UIPanel.SetActive(false);
            isShown = false;
        }
    }
}