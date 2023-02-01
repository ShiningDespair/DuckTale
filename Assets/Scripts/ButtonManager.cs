using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class ButtonManager : MonoBehaviour
{
    public GameObject startMenuPanel;
    public GameObject optionsPanel;

    public void StartGame()
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Playground"));
    }

    public void OpenOptions()
    {
        optionsPanel.SetActive(true);
        startMenuPanel.SetActive(false);
    }

    public void BackButton()
    {
        optionsPanel.SetActive(false);
        startMenuPanel.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit succesful");
    }

}


