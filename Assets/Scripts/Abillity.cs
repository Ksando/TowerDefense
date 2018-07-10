//
// Created by absdspr
//
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abillity : MonoBehaviour
{

    private double upgradeCost;
    private double buyCost;
	// Use this for initialization
	void Start ()
    {

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
}
