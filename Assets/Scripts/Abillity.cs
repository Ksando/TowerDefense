//
// Created by absdspr
//
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abillity : MonoBehaviour
{
    Player player;
    Multipliers multi;
    Vector2 position;
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
       
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
            position = Input.mousePosition;
    }
        
    public void setAbilltys(string value)
    {
        switch(value)
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
                break;
        }
    }

    public void engineerAbillitys()
    {
        Debug.Log("Я у мамы инженер");
    }

    public void scientistAbillitys()
    {
      
        Debug.Log("Учоный");
    }

    public void generalAbillitys()
    {
       
        Debug.Log("Я генерал");
    }
    //Активаня спосбность инженера
    public void openCore()
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
           
            float distance = Vector2.Distance(position, enemy.transform.position); //Проверка растояния, входит ли враг в область поражения
            Debug.Log(distance);
            if(distance <= 645)
            { 
                enemy.GetComponent<Enemy>().TakeDamage(200);
            }
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
