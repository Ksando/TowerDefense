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

    //Геттеры и сеттеры
    public void setHealthMulti( string monster)
    {
        switch(monster)
        {
            case "Simple":
                healthMultiSimple = healthMultiSimple + healthMultiSimple * 0.1f;
                break;
            case "Tank":
                healthMultiTank = healthMultiTank + healthMultiTank * 0.15f;
                break;
            case "Fast":
                healthMultiFast = healthMultiSimple + healthMultiTank * 0.1f;
                break;    
        }
    }
    public float getHealthMulti(string monster)
    {
        switch (monster)
        {
            case "Simple":
                return healthMultiSimple;
            case "Tank":
                return healthMultiTank;
            case "Fast":
                return healthMultiFast;
            default:
                return -1;
              
        }
        
    }
    public void setSpeedMulti(string monster)
    {
        switch (monster)
        {
            case "Simple":
                speedMultiSimple = speedMultiSimple * 1;//Остается прежней
                break;
            case "Tank":
                speedMultiTank = speedMultiTank * 1;//Остается прежней
                break;
            case "Fast":
                speedMultiFast = speedMultiFast + speedMultiFast * 0.05f;
                break;
        }
    }
    public float getSpeedMulti(string monster)
    {
        switch (monster)
        {
            case "Simple":
                return speedMultiSimple;
            case "Tank":
                return speedMultiTank;        
            case "Fast":
                return speedMultiFast;        
            default:
                return -1;
            
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
    public void setDamageMulti(float value, string something)
    {
        switch (something)
        {        
            case "DefaultTower":
                damageMultiTowerSimple = value;
                break;
            case "SlownigTower":
                damageMultiTowerSlow = value;
                break;
            case "SniperTower":
                damageMultiTowerSniper = value;
                break;
            case "TowerAOE":
                damageMultiTowerAOE = value;
                break;
            case "RapidTower":
                damageMultiTowerFast = value;
                break;
        }
    }
    public void setDamageMulti(string something)
    {
        switch (something)
        {
            case "Simple":
                damageMultiSimple += 1;
                break;
            case "Tank":
                damageMultiTank += 1;
                break;
            case "Fast":
                damageMultiFast += 1;
                break;
        }
    }
    public float getDamageMulti(string something)
    {
        switch (something)
        {
            case "Simple":
                return damageMultiSimple;
            case "Tank":
                return damageMultiTank;
            case "Fast":
                return damageMultiFast;
            case "DefaultTower":
                return damageMultiTowerSlow;
            case "SlownigTower":
                return damageMultiTowerSlow;
            case "SniperTower":
                return damageMultiTowerSniper;
            case "TowerAOE":
                return damageMultiTowerAOE;
            case "RapidTower":
                return damageMultiTowerFast;
            default:
                return -1;
        }
    }
   
    public void setReloadMulti(float value, string something)
    {
        switch (something)
        {
            case "DefaultTower":
                reloadMultiTowerSimple = value;
                break;
            case "SlownigTower":
                reloadMultiTowerSlow = value;
                break;
            case "SniperTower":
                reloadMultiTowerSniper = value;
                break;
            case "TowerAOE":
                reloadMultiTowerAOE = value;
                break;
            case "RapidTower":
                reloadMultiTowerFast = value;
                break;
        }
    }
    public float getReloadMulti(string something)
    {
        switch(something)
        {
            case "DefaultTower":
                return reloadMultiTowerSimple;               
            case "SlownigTower":
                return reloadMultiTowerSlow;             
            case "SniperTower":
                return reloadMultiTowerSniper;            
            case "TowerAOE":
                return reloadMultiTowerAOE;        
            case "RapidTower":
                return reloadMultiTowerFast;
            default:
                return -1;               
        }
    }
    // Use this for initialization
    void Start ()
    {
        healthMultiFast = 1;
        healthMultiSimple = 1;
        healthMultiTank = 1;

        speedMultiFast = 1;
        speedMultiSimple = 1;
        speedMultiTank = 1;

        damageMultiFast = 1;
        damageMultiSimple = 1;
        damageMultiTank = 1;

        damageMultiTowerSimple = 1;
        damageMultiTowerSlow = 1;
        damageMultiTowerSniper = 1;
        damageMultiTowerAOE = 1;
        damageMultiTowerFast = 1;

        reloadMultiTowerAOE = 1;
        reloadMultiTowerFast = 1;
        reloadMultiTowerSimple = 1;
        reloadMultiTowerSniper = 1;
        reloadMultiTowerSlow = 1;

    }
	// Update is called once per frame
	void Update ()
    {
		
	}
}
