using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour {

    AudioSource audio;
    Settings sets;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
        sets = GetComponent<Settings>();
	}
	
	// Update is called once per frame
	void Update () {
        audio.volume = sets.musicVolume;
	}
}
