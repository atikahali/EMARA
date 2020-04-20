using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{

    public void ImbasGambar()
    {
        SceneManager.LoadScene("scanMenu");
    }

    public void Info()
    {
        SceneManager.LoadScene("heartMenu");

    }

    public void UjiKefahaman()
    {
        SceneManager.LoadScene("assessment");

    }

    public void Keluar()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
