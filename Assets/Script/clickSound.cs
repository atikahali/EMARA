﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickSound : MonoBehaviour {

    public AudioClip click;

	// Use this for initialization
	void Start () {
        AudioSource.PlayClipAtPoint(click, transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
