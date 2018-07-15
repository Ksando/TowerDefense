﻿//
// Created by absdspr
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour {


    public GameObject pauseButton;
    public GameObject pauseMenu;
    public GameObject settingsMenu;
    Slider soundVolume; // Slider2
    Slider musicVolume; // Slider1
    Settings settings;

    void Start()
    {
        pauseButton.SetActive(true);
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(false);
        settings = GameObject.Find("Settings").GetComponent<Settings>();
        soundVolume = GameObject.Find("Slider2").GetComponent<Slider>();
        musicVolume = GameObject.Find("Slider1").GetComponent<Slider>();
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
        Time.timeScale = 1f;
        SceneManager.LoadScene("FirstScene");
    }
    public void gameSettings()
    {
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(true);
        musicVolume.value = settings.musicVolume;
        soundVolume.value = settings.soundsVolume;
    }
    public void confirmChanges()
    {
        settingsMenu.SetActive(false);
        pauseMenu.SetActive(true);
        settings.setMusicVolume();
        settings.setSoundsVolume();
    }
}
