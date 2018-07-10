//
// Created by absdspr
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multipliers : MonoBehaviour
{
    //На что умножать характеристику при увелечнии уровня башни или врага
    private int healthMulti;
    private int moneyMulti; 
    private int speedMulti;
    private int damageMulti;
    private int reloadMulti;
    private int rangeMulti;
    private int slowTimeMulti;
    //Геттеры и сеттеры
    public void setHealthMulti(int value)
    {
        healthMulti = value;
    }
    public int getHealthMulti()
    {
        return healthMulti;
    }
    public void setMoneyMulti(int value)
    {
        moneyMulti = value;
    }
    public int getMoneyMulti()
    {
        return moneyMulti;
    }
    public void setSpeedMulti(int value)
    {
        speedMulti = value;
    }
    public int getSpeedMulti()
    {
        return speedMulti;
    }
    public void setDamageMulti(int value)
    {
        damageMulti = value;
    }
    public int getDamageMulti()
    {
        return damageMulti;
    }
    public void setRangeMulti(int value)
    {
        rangeMulti = value;
    }
    public int getRangeMulti()
    {
        return rangeMulti;
    }
    public void setReloadMulti(int value)
    {
        reloadMulti = value;
    }
    public int getReloadMulti()
    {
        return reloadMulti;
    }
    public void setSlowTimeMulti(int value)
    {
        slowTimeMulti = value;
    }
    public int getSlowTimeMulti()
    {
        return slowTimeMulti;
    }
    // Use this for initialization
    void Start ()
    {
		
	}
	// Update is called once per frame
	void Update ()
    {
		
	}
}
