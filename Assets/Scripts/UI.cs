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
    public GameObject useAbilltiyButton;
 

	void Start ()
    {
        player = GameObject.Find("Main Camera").GetComponent<Player>();
        money = GameObject.Find("Money").GetComponent<Text>();
        wave = GameObject.Find("WaveSpawner").GetComponent<WaveSpawner>();
        currentWave = GameObject.Find("currentWaveText").GetComponent<Text>();
        if(player.getClassName() == "General")
            useAbilltiyButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("UI/b5");
        else if(player.getClassName() == "Scientist")
            useAbilltiyButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("UI/b4");
        else if(player.getClassName() == "Engineer")
            useAbilltiyButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("UI/b6");
    }

    // Update is called once per frame
    void Update()
    {
        money.text = player.getMoney().ToString() + "$";
        currentWave.text = "Current wave is " + wave.getWaveIndex().ToString();
    }
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
    public void gameSpeed()//Меняет скорость игры поочередно
    {
        if (Time.timeScale == 1)
        {
            fastGame();
            speedGameButton.GetComponent<Image>().sprite =Resources.Load<Sprite>("UI/b3") ;
        }
        else if (Time.timeScale == 2)
        {
            PauseGame();
            speedGameButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("UI/b1");
        }
        else if (Time.timeScale == 0)
        {
            normalizeGame();
            speedGameButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("UI/b2");
        }
    }
}
