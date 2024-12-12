using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    

    public void CarregaFase(int cena)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(cena);

    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
   
        PlayerPrefs.DeleteKey("ScoreM");
        PlayerPrefs.DeleteKey("HighScoreM");
        GameManager.scoreNumberM = 0;
        GameManager.scoreNumberM = 0;
    }

    public void Sair()
    {
        Application.Quit();
    }
}
