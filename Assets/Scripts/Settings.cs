/** Настройки игры. Автор - Максим **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour {
    
    public string className;
    public int levelNum;
    public float musicVolume = 1;
    public float soundsVolume = 1;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setMusicVolume()
    {
        musicVolume = GameObject.Find("Slider1").GetComponent<Slider>().value;
    }

    public void setSoundsVolume()
    {
        soundsVolume = GameObject.Find("Slider2").GetComponent<Slider>().value;
    }
}
