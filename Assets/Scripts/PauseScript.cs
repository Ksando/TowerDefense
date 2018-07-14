//
// Created by absdspr
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour {


    public GameObject pauseButton;
    public GameObject pauseMenu;
    public GameObject settingsMenu;

    void Start()
    {
       pauseButton.SetActive(true);
       pauseMenu.SetActive(false);
       settingsMenu.SetActive(false);

       Time.timeScale = 1f;
    }
    public void PauseGame()
    {
        pauseButton.SetActive(false);
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void resumeGame()
    {
        pauseButton.SetActive(true);
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void menu()
    {
        SceneManager.LoadScene("FirstScene");
    }
    public void gameSettings()
    {
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
    public void confirmChanges()
    {
        settingsMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }

}
