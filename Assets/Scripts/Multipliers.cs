//
// Created by absdspr
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multipliers : MonoBehaviour
{
    //На что умножать характеристику при увелечнии уровня башни или врага
    private float healthMultiSimple;
    private float healthMultiFast;  //Множители хп врагов
    private float healthMultiTank;

    private float moneyMultiSimple;
    private float moneyMultiFast;  //Множители наград за врагов
    private float moneyMultiTank;

    private float speedMultiSimple;
    private float speedMultiFast;    //Множители скорости врагов
    private float speedMultiTank;

    private float damageMultiSimple;
    private float damageMultiFast;  //Множители урона врагов
    private float damageMultiTank;

    private float damageMultiTowerSimple;
    private float damageMultiTowerSlow;   //Множители урона башен
    private float damageMultiTowerSniper;
    private float damageMultiTowerAOE;
    private float damageMultiTowerFast;

    private float reloadMultiTowerSimple;
    private float reloadMultiTowerSlow; //Множители перезарядки башен
    private float reloadMultiTowerSniper;
    private float reloadMultiTowerAOE;
    private float reloadMultiTowerFast;

    private float rangeMultiTowerSimple;
    private float rangeMultiTowerSlow;
    private float rangeMultiTowerSniper;
    private float rangeMultiTowerAOE;
    private float rangeMultiTowerFast;

    private float slowTimeMulti;
    //Геттеры и сеттеры
    public void setHealthMulti(float value, string monster)
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
    public float getHealthMulti(string monster)
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
    public void setMoneyMulti(float value, string monster)
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
    public float getMoneyMulti(string monster)
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
    public void setSpeedMulti(float value, string monster)
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
    public float getSpeedMulti(string monster)
    {
        switch (monster)
        {
            case "Simple":
                return speedMultiSimple;
                break;
            case "Tank":
                return speedMultiTank;
                break;
            case "Fast":
                return speedMultiFast;
                break;
            default:
                return -1;
                break;
        }
    }
    public void setDamageMulti(float value, string something)
    {
        switch (something)
        {
            case "Simple":
                damageMultiSimple = value;
                break;
            case "Tank":
                damageMultiTank = value;
                break;
            case "Fast":
                damageMultiFast = value;
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
            case "TowerFast":
                damageMultiTowerFast = value;
                break;
        }
    }
    public float getDamageMulti(string something)
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
            case "TowerFast":
                return damageMultiTowerFast;
            default:
                return -1;
                break;
        }
    }
    public void setRangeMulti(float value, string something)
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
            case "TowerFast":
                rangeMultiTowerFast = value;
                break;
        }
    }
    public float getRangeMulti(string something)
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
            case "TowerFast":
                return rangeMultiTowerFast;
                break;
            default:
                return -1;
                break;
                
        }
    }
    public void setReloadMulti(float value, string something)
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
            case "TowerFast":
                reloadMultiTowerFast = value;
                break;
        }
    }
    public float getReloadMulti(string something)
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
            case "TowerFast":
                return reloadMultiTowerFast;
                break;
            default:
                return -1;
                break;
        }
    }
    public void setSlowTimeMulti(float value)
    {
        slowTimeMulti = value;
    }
    public float getSlowTimeMulti()
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
