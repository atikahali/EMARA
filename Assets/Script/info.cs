using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class info : MonoBehaviour {

    public void Kembali()
    {
        SceneManager.LoadScene("mainMenu");
    }

    public void Info()
    {
        SceneManager.LoadScene("heart");
    }
}
