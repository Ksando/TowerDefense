//
// Created by absdspr
//
using UnityEngine;


public class Player : MonoBehaviour
{
    UI userInterface;
    private string className;
    private int money;
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
        userInterface.noMoneyNotification();
        return false;
    }

    // Use this for initialization
    private void Awake()
    {
        money = 150;
    }
    private void Start ()
    {
        className = GameObject.Find("Settings").GetComponent<Settings>().className;
        userInterface = GameObject.Find("Main UI").GetComponent<UI>();
    }
}
