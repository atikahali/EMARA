using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    Text scores;
    public static int scoreValue = 0;

	// Use this for initialization
	void Start () {
        scores = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        scores.text = "Skor: " + scoreValue;
	}
}
