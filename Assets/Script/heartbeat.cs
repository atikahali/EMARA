using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heartbeat : MonoBehaviour
{

    public AudioClip heartbeatSound;

    // Use this for initialization
    void Start()
    {
        AudioSource.PlayClipAtPoint(heartbeatSound, transform.position);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
