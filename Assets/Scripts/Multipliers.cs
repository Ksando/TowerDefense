//
// Created by absdspr
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multipliers : MonoBehaviour
{
    //На что умножать характеристику при увелечнии уровня башни или врага
    private int healthMultiSimple;
    private int healthMultiFast;  //Множители хп врагов
    private int healthMultiTank;

    private int moneyMultiSimple;
    private int moneyMultiFast;  //Множители наград за врагов
    private int moneyMultiTank;

    private int speedMultiSimple;
    private int speedMultiFast;    //Множители скорости врагов
    private int speedMultiTank;

    private int damageMultiSimple;
    private int damageMultiFast;  //Множители урона врагов
    private int damageMultiTank;

    private int damageMultiTowerSimple;
    private int damageMultiTowerSlow;   //Множители урона башен
    private int damageMultiTowerSniper;
    private int damageMultiTowerAOE;

    private int reloadMultiTowerSimple;
    private int reloadMultiTowerSlow; //Множители перезарядки башен
    private int reloadMultiTowerSniper;
    private int reloadMultiTowerAOE;

    private int rangeMultiTowerSimple;
    private int rangeMultiTowerSlow;
    private int rangeMultiTowerSniper;
    private int rangeMultiTowerAOE;

    private int slowTimeMulti;
    //Геттеры и сеттеры
    public void setHealthMulti(int value, string monster)
    {
        switch(monster)
        {
            case "Simple":
                healthMultiSimple = value;
                break;
            case "Tank":
                healthMultiTank = value;
                break;
            case "Fast":
                healthMultiFast = value;
                break;    
        }
    }
    public int getHealthMulti(string monster)
    {
        switch (monster)
        {
            case "Simple":
                return healthMultiSimple;
                break;
            case "Tank":
                return healthMultiTank;
                break;
            case "Fast":
                return healthMultiFast;
                break;
            default:
                return -1;
                break;
        }
        
    }
    public void setMoneyMulti(int value, string monster)
    {
        switch (monster)
        {
            case "Simple":
                moneyMultiSimple = value;
                break;
            case "Tank":
                moneyMultiTank = value;
                break;
            case "Fast":
                moneyMultiFast = value;
                break;
        }
    }
    public int getMoneyMulti(string monster)
    {
        switch (monster)
        {
            case "Simple":
                return moneyMultiSimple;
                break;
            case "Tank":
                return moneyMultiTank;
                break;
            case "Fast":
                return moneyMultiFast;
                break;
            default:
                return -1;
                break;
        }
    }
    public void setSpeedMulti(int value, string monster)
    {
        switch (monster)
        {
            case "Simple":
                speedMultiSimple = value;
                break;
            case "Tank":
                speedMultiTank = value;
                break;
            case "Fast":
                speedMultiFast = value;
                break;
        }
    }
    public int getSpeedMulti(string monster)
    {
        switch (monster)
        {
            case "Simple":
                return moneyMultiSimple;
                break;
            case "Tank":
                return moneyMultiTank;
                break;
            case "Fast":
                return moneyMultiFast;
                break;
            default:
                return -1;
                break;
        }
    }
    public void setDamageMulti(int value, string something)
    {
        switch (something)
        {
            case "Simple":
                healthMultiSimple = value;
                break;
            case "Tank":
                healthMultiTank = value;
                break;
            case "Fast":
                healthMultiFast = value;
                break;
            case "TowerSimple":
                damageMultiTowerSimple = value;
                break;
            case "TowerSlow":
                damageMultiTowerSlow = value;
                break;
            case "TowerSniper":
                damageMultiTowerSniper = value;
                break;
            case "TowerAOE":
                damageMultiTowerAOE = value;
                break;
        }
    }
    public int getDamageMulti(string something)
    {
        switch (something)
        {
            case "Simple":
                return damageMultiSimple;
                break;
            case "Tank":
                return damageMultiTank;
                break;
            case "Fast":
                return damageMultiFast;
                break;
            case "TowerSimple":
                return damageMultiTowerSlow;
                break;
            case "TowerSlow":
                return damageMultiTowerSlow;
                break;
            case "TowerSniper":
                return damageMultiTowerSniper;
                break;
            case "TowerAOE":
                return damageMultiTowerAOE;
                break;
            default:
                return -1;
                break;
        }
    }
    public void setRangeMulti(int value, string something)
    {
        switch (something)
        {
            case "TowerSimple":
                rangeMultiTowerSimple = value;
                break;
            case "TowerSlow":
                rangeMultiTowerSlow = value;
                break;
            case "TowerSniper":
                rangeMultiTowerSniper = value;
                break;
            case "TowerAOE":
                rangeMultiTowerAOE = value;
                break;
        }
    }
    public int getRangeMulti(string something)
    {
        switch (something)
        {
            case "TowerSimple":
               return rangeMultiTowerSimple;
                break;
            case "TowerSlow":
                return rangeMultiTowerSlow ;
                break;
            case "TowerSniper":
                return rangeMultiTowerSniper;
                break;
            case "TowerAOE":
                 return rangeMultiTowerAOE;
                break;
            default:
                return -1;
                break;
                
        }
    }
    public void setReloadMulti(int value, string something)
    {
        switch (something)
        {
            case "TowerSimple":
                reloadMultiTowerSimple = value;
                break;
            case "TowerSlow":
                reloadMultiTowerSlow = value;
                break;
            case "TowerSniper":
                reloadMultiTowerSniper = value;
                break;
            case "TowerAOE":
                reloadMultiTowerAOE = value;
                break;
        }
    }
    public int getReloadMulti(string something)
    {
        switch(something)
        {
            case "TowerSimple":
                return reloadMultiTowerSimple;
                break;
            case "TowerSlow":
                return reloadMultiTowerSlow;
                break;
            case "TowerSniper":
                return reloadMultiTowerSniper;
                break;
            case "TowerAOE":
                return reloadMultiTowerAOE;
                break;
            default:
                return -1;
        }
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
