//
// Created by absdspr
//
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour {

    Player player;
    Text money;
    Base mainBase;

    Text currentWave;
    WaveSpawner wave;
    Abillity abillity;
    public GameObject speedGameButton;
    public GameObject useAbilltiyButton;

    public GameObject noMoney;
    public GameObject cooldown;

    public GameObject endScreen;
    public GameObject endGameButton;
    public GameObject finalScore;
    public GameObject gameResult;
    private float enemyBossHealth;


  
	void Start ()
    {
        player = GameObject.Find("Main Camera").GetComponent<Player>();
        abillity = GameObject.Find("Main Camera").GetComponent<Abillity>();
        money = GameObject.Find("Money").GetComponent<Text>();
        wave = GameObject.Find("WaveSpawner").GetComponent<WaveSpawner>();
        currentWave = GameObject.Find("currentWaveText").GetComponent<Text>();
        mainBase = GameObject.Find("Base").GetComponent<Base>();
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
        if (mainBase.BaseHealth == 0)
        {
            endScreen.SetActive(true);
            gameResult.GetComponent<Image>().sprite = Resources.Load<Sprite>("UI/text5");
            gameResult.SetActive(true);
            finalScore.GetComponent<Text>().text = player.getScore().ToString();
            finalScore.SetActive(true);
            endGameButton.SetActive(true);
        }
        else if (wave.waveCountdownText.ToString() == "Last")
        {
            enemyBossHealth = GameObject.FindGameObjectWithTag("BossMutant").GetComponent<Enemy>().health;
            if(enemyBossHealth <=0)
            {
                endScreen.SetActive(true);
                gameResult.GetComponent<Image>().sprite = Resources.Load<Sprite>("UI/text4");
                finalScore.GetComponent<Text>().text = player.getScore().ToString();
                endGameButton.SetActive(true);
            }

        }
    }

    public void closeEndScreen()
    {
        endScreen.SetActive(false);
        gameResult.GetComponent<Text>().text = "Вы победили!";
        endGameButton.SetActive(false);
        SceneManager.LoadScene("FirstScene");
    }
    public void restart()
    {
        endScreen.SetActive(false);
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
    public IEnumerator noMoneyNotification()
    {
        noMoney.GetComponent<Text>().text = "Не хватает средств!";
        Color tmp = noMoney.GetComponent<Text>().color;
        tmp.a = 255f;
        noMoney.GetComponent<Text>().color = tmp;
        yield return new WaitForSecondsRealtime(1);
        for (float i = 5; i >= 0; i -= Time.deltaTime)
        {
            tmp.a -= 255f/5f;
            noMoney.GetComponent<Text>().color = tmp;
        }
    }
    public IEnumerator abillityCooldown()
    {
        cooldown.GetComponent<Text>().text = "Перезарядка способности, осталось "+Math.Round(abillity.getAbillityCooldown()).ToString()+" сек.";
        Color tmp = cooldown.GetComponent<Text>().color;
        tmp.a = 255f;
        cooldown.GetComponent<Text>().color = tmp;
        yield return new WaitForSecondsRealtime(1);
        for (float i = 5; i >= 0; i -= Time.deltaTime)
        {
            tmp.a -= 255f / 15f;
            cooldown.GetComponent<Text>().color = tmp;
        }
    }
}
