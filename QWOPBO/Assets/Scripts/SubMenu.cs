using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubMenu : MonoBehaviour
{
    public GameObject exploreControls;
    public GameObject fightControls;
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
        //SceneManager.LoadScene("ExploreMode");
        exploreControls.SetActive(true);
    }

    public void FightMode()
    {
        print("Fight");
        fightControls.SetActive(true);
    }

    public void ReturnMode()
    {
        exploreControls.SetActive(false);
        fightControls.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
