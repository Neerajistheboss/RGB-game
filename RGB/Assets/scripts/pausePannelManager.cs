using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pausePannelManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]GameObject pausePannel;
    public void playAgain()
    {
        pausePannel.SetActive(false);
        rayHit.gameOver = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("gameplay");
    }

    public void mainMenu()
    {
        pausePannel.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("mainMenu");
    }
}
