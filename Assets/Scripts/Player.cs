using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    private string className;
    private int money;
    Abillity abillity = new Abillity();
    public int getMoney()
    {
        return money;
    }
    //Adding money to player
    public void setMoney(int value)
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
            this.setMoney(-value);
            return true;
        }
        Debug.Log("no money");
        return false;
    }
   
	// Use this for initialization
	void Start () {
        money = 150;
        abillity.setAbilltys(className);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
