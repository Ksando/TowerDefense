//
// Created by absdspr
//
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abillity : MonoBehaviour
{
    public Player player;
    public Multipliers multi;
    private string className;
    Vector2 position;
    private int abilityCouldown;
    private float [] previousMultiSpeed = new float[3];
    private float [] previousMultiDamage = new float[5];
    private float [] previousMultiReload = new float[5];
    private string[] towers = {"TowerSimple","TowerSlow","TowerSniper","TowerAOE","TowerFast" };
    private string[] enemys = { "Simple", "Fast", "Tank" };

    // Use this for initialization
    void Start ()
    {
        player = GetComponent<Player>();
        multi = GetComponent<Multipliers>();
        this.className = player.getClassName();
        switch(this.className)
        {
            case "General":
                abilityCouldown = 30;
                break;
            case "Scientist":
                abilityCouldown = 15;
                break;
            case "Engineer":
                abilityCouldown = 25;
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
        
    public void useAbility()
    {
        switch(this.className)
        {
            case "General":
                generalAbillitys();
                break;
            case "Scientist":
                scientistAbillitys();
                break;
            case "Engineer":
                engineerAbillitys();
                break;
            default:
                Debug.Log("No class");
                break;
        }
    }
    //Тестовые способки
    public void engineerAbillitys()
    {
        Debug.Log("Я у мамы инженер");
        Debug.Log(abilityCouldown);
    }

    public void scientistAbillitys()
    {
      
        Debug.Log("Ученый");
        Debug.Log(abilityCouldown);
    }
    public void generalAbillitys()
    {
        Debug.Log("Я генерал");
    }
    //Активаня спосбность инженера
    IEnumerator openCore()
    {
        //Получаем старые значения множителей
        for (int i = 0; i < towers.Length; i++)
        {
            previousMultiDamage[i] = multi.getDamageMulti(towers[i]);
            previousMultiReload[i] = multi.getReloadMulti(towers[i]);
        }
        //Увеличиваем их на n времени
        for (int i = 0; i < towers.Length; i ++)
        {
            multi.setDamageMulti(1.5f * previousMultiDamage[i], towers[i]);
            multi.setReloadMulti(1.5f * previousMultiReload[i], towers[i]); 
        }
        yield return new WaitForSecondsRealtime(5);
        //
        //Возвращаем их обратно
        for (int i = 0; i < towers.Length; i++)
        {
            multi.setDamageMulti(previousMultiDamage[i], towers[i]);
            multi.setReloadMulti(previousMultiReload[i], towers[i]);
        }

    }
    //Ракетный удар
    public void rocketPunch()   
    {
        foreach(GameObject enemy in GameObject.FindGameObjectsWithTag("enemy"))
        {
           enemy.GetComponent<Enemy>().TakeDamage(200);
        }

    }
    public void cryogen()
    {
        //Получаем старые значения множителей
        for (int i = 0; i < enemys.Length; i++)
        {
            previousMultiSpeed[i] = multi.getSpeedMulti(enemys[i]);
        }
        for (int i = 0; i < enemys.Length; i++)
        {
            multi.setSpeedMulti(0, enemys[i]);
        }
        for(int i = 0; i <enemys.Length; i++)
        {
            multi.setSpeedMulti(previousMultiSpeed[i], enemys[i]);
        }
    }
    




}
