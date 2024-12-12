using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public void PauseGame()
    {
        //pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void continuar()
    {
      //  pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
