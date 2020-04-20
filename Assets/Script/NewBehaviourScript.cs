using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playsound : MonoBehaviour {

    GameObject BPlay;
	// Use this for initialization
	void Start () {
        BPlay = GameObject.Find("Play");
   
        BPlay.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Play")
                {
                    BPlay.SetActive(true);
                    BPlay.GetComponent<AudioSource>().Play();
                }
            }
        }
	}
}
