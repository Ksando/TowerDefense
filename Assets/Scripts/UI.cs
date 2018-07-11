//
// Created by absdspr
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    Player player;
    Text money;
    Text currentWave;

	void Start ()
    {
        player = GameObject.Find("Main Camera").GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        money = GameObject.Find("Text").GetComponent<Text>();
        money.text = player.getMoney().ToString()+"$";
        
    }


}
