using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDoisTomada : MonoBehaviour
{
    public Text scoreText;
    public static int scoreNumber;


    void Start()
    {

        PlayerPrefs.GetInt("Score", scoreNumber);
    }


    void Update()
    {

        PlayerPrefs.SetInt("Score", scoreNumber);
        scoreText.text = scoreNumber.ToString();

        if (PlayerPrefs.GetInt("HighScore") < scoreNumber)

            PlayerPrefs.SetInt("HighScore", scoreNumber);
    }
}