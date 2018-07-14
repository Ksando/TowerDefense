//
// Created by absdspr
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    Player player;
    Text money;
    Text currentWave;
    WaveSpawner wave;
    public GameObject speedGame;
    public GameObject control;
    public GameObject pauseGame;
    public GameObject normalGame;

	void Start ()
    {
        player = GameObject.Find("Main Camera").GetComponent<Player>();
        money = GameObject.Find("Money").GetComponent<Text>();
        wave = GameObject.Find("WaveSpawner").GetComponent<WaveSpawner>();
        currentWave = GameObject.Find("currentWaveText").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        money.text = player.getMoney().ToString() + "$";
        currentWave.text = "Current wave is " + wave.getWaveIndex().ToString();
    }
    //Доделать!!
    public void fastGame()
    {
        Time.timeScale = 2f;
       
    }
    public void normalizeGame()
    {
        Time.timeScale = 1f;
        
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
}
