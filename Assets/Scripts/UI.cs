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
    public GameObject speedGameButton;
 

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
    public void fastGame()
    {
        Time.timeScale = 2;
       
    }
    public void normalizeGame()
    {
        Time.timeScale = 1;
        
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void gameSpeed()//Меняет скорость игры поочередно
    {
        if (Time.timeScale == 1)
        {
            fastGame();
            speedGameButton.GetComponentInChildren<Text>().text = "2x speed";
        }
        else if (Time.timeScale == 2)
        {
            PauseGame();
            speedGameButton.GetComponentInChildren<Text>().text = "zero speed";
        }
        else if (Time.timeScale == 0)
        {
            normalizeGame();
            speedGameButton.GetComponentInChildren<Text>().text = "Normal speed";
        }
    }
}
