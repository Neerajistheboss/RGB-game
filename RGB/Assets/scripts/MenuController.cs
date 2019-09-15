using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    



    public void play()
    {
        SceneManager.LoadScene("gameplay");
    }

    public void instructions()
    {
        SceneManager.LoadScene("instructions");
    }

    public void leaderBoard()
    {
        SceneManager.LoadScene("leaderboard");
    }

    public void quit()
    {
        Application.Quit();
    }

    public void back()
    {
        SceneManager.LoadScene("mainMenu");
    }

}
