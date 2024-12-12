using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TomadaUmQuarto : MonoBehaviour
{
    public GameObject tampaDaTomadaQuartoUm, tampaDaTomadaQuartoUmBlack;

    public GameObject PanelVenceu;

    public GameObject timer;

    public int score;


    // public string Perde;

    Vector3 initialTampaDaTomadaPosition;

    bool tampaDaTomadaBool = false;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;


    void Start()
    {
        timer.SetActive(true);
        Timer.time = 20;
        PanelVenceu.SetActive(false);
        ScoreUmTomada.scoreNumber = 0;
        initialTampaDaTomadaPosition = tampaDaTomadaQuartoUm.transform.position;
    }
    public void DragTampa()
    {
        tampaDaTomadaQuartoUm.transform.position = Input.mousePosition;
    }
    public void DropTampa()
    {
        float distance = Vector3.Distance(tampaDaTomadaQuartoUm.transform.position, tampaDaTomadaQuartoUmBlack.transform.position);
        if (distance < 50)
        {
            tampaDaTomadaQuartoUm.transform.position = tampaDaTomadaQuartoUmBlack.transform.position;
            ScoreUmTomada.scoreNumber += 1;
            tampaDaTomadaBool = true;
            if (tampaDaTomadaBool == true)
            {
                GameManager.scoreNumberM++;
            }
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            tampaDaTomadaQuartoUm.transform.position = initialTampaDaTomadaPosition;
            source.clip = incorrect;
            source.Play();
        }
    }

    void LateUpdate()
    {
        if (ScoreUmTomada.scoreNumber >= 1)
        {
            //Destroy(timer);
            timer.SetActive(false);
            PanelVenceu.SetActive(true);
        }
    }
}
