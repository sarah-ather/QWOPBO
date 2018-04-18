using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene("texturedmap Fight Scene");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void LoadStart()
    {
        SceneManager.LoadScene("Start");
    }

    public void ExploreMode()
    {
        SceneManager.LoadScene("ExploreMode");
    }

    public void FightMode()
    {
        SceneManager.LoadScene("FightMode");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Return()
    {
        SceneManager.LoadScene("End");
    }
}
