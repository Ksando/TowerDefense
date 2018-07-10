//
// Created by absdspr
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    int money;
    Player player;
    Text text;

	void Start ()
    {
        player = GameObject.Find("Main Camera").GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        text = GameObject.Find("Text").GetComponent<Text>();
        text.text = player.getMoney().ToString()+"$";
        
    }


}
