﻿//
// Created by absdspr
//
using UnityEngine;


public class Player : MonoBehaviour
{
    UI userInterface;
    private string className;
    private int money;
    private int score;
    public int getMoney()
    {
        return money;
    }
    //Adding money to player
    public void addMoney(int value)
    {
       money = money + value;
    }
    public string getClassName()
    {
        return className;
    }
    public void setClassName(string value)
    {
        className = value;
    }
    public int getScore()
    {
        return score;
    }
    public bool buySomething(int value)
    {
        if (this.money >= value)
        {
            this.addMoney(-value);
            return true;
        }
        userInterface.StartCoroutine("noMoneyNotification");
        return false;
    }

    // Use this for initialization
    private void Awake()
    {
        money = 150;
    }
    private void Start ()
    {
        className = GameObject.Find("Settings").GetComponent<Settings>().className;
        userInterface = GameObject.Find("Main UI").GetComponent<UI>();
    }
    private void Update()
    {
		if (GameObject.Find("Base"))
			score = money + (int) GameObject.Find("Base").GetComponent<Base>().BaseHealth;
		else
			score = 0;
    }
}
