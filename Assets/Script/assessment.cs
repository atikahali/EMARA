using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class assessment : MonoBehaviour
{

    public void Mula()
    {
        SceneManager.LoadScene("assessment1");
    }

    public void Answer1()
    {
        SceneManager.LoadScene("assessment2");
        score.scoreValue += 1;
    }

    public void Answer2()
    {
        SceneManager.LoadScene("assessment3");
        score.scoreValue += 1;
    }

    public void Answer3()
    {
        SceneManager.LoadScene("assessment4");
        score.scoreValue += 1;
    }

    public void Answer4()
    {
        SceneManager.LoadScene("assessment5");
        score.scoreValue += 1;
    }

    public void Answer5()
    {
        SceneManager.LoadScene("assessment6");
        score.scoreValue += 1;
    }

    public void Answer6()
    {
        SceneManager.LoadScene("assessment7");
        score.scoreValue += 1;
    }

    public void Answer7()
    {
        SceneManager.LoadScene("assessment8");
        score.scoreValue += 1;
    }

    public void Answer8()
    {
        SceneManager.LoadScene("assessment9");
        score.scoreValue += 1;
    }

    public void Answer9()
    {
        SceneManager.LoadScene("assessment10");
        score.scoreValue += 1;
    }

    public void Answer10()
    {
        score.scoreValue += 1;
        SceneManager.LoadScene("assessment11");
    }
}