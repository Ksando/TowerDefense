﻿//
// Created by absdspr
//
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string className;
    private int money;
    Abillity abillity;
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
    public bool buySomething(int value)
    {
        if (this.money >= value)
        {
            this.addMoney(-value);
            return true;
        }
        Debug.Log("no money");
        return false;
    }

    // Use this for initialization
    private void Awake()
    {
        money = 150;
    }
    void Start ()
    {
        abillity = GetComponent<Abillity>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
