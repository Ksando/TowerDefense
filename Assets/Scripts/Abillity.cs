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
    private float [] previousMultiSpeed = new float[4];
    private float [] previousMultiDamage = new float[4];
    private string[] names = {"TowerSimple","TowerSlow","TowerSniper","TowerAOE" };

    // Use this for initialization
    void Start ()
    {
        player = GetComponent<Player>();
        multi = GetComponent<Multipliers>();
        for(int i = 0; i < names.Length; i++)
        {
            previousMultiDamage[i] = multi.getDamageMulti(names[i]);
            previousMultiSpeed[i] = multi.getSpeedMulti(names[i]);
        }
    }
	// Update is called once per frame
	void Update ()
    {
		
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
        Debug.Log("Я у мамы инжинер");
    }

    public void scientistAbillitys()
    {
      
        Debug.Log("Учоный");
    }

    public void generalAbillitys()
    {
       
        Debug.Log("Я генерал");
    }
    public void openCore()
    {
       for(int i = 0; i < names.Length; i ++)
        {
            multi.setDamageMulti(1.5f, names[i]);
            multi.setReloadMulti(1.5f, names[i]);
        }
       
    }


}
