using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TomadaTresQuarto : MonoBehaviour
{
    public GameObject tampaQuartoTres, tampaQuartoTresBlack;

    public GameObject PanelVenceu;

    public GameObject timer;

    public int score;

    //public string Perde;

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
        ScoreTomadaTres.scoreNumber = 0;
        initialTampaDaTomadaPosition = tampaQuartoTres.transform.position;
    }
    public void DragTampa()
    {
        tampaQuartoTres.transform.position = Input.mousePosition;
    }
    public void DropTampa()
    {
        float distance = Vector3.Distance(tampaQuartoTres.transform.position, tampaQuartoTresBlack.transform.position);
        if (distance < 50)
        {
            tampaQuartoTres.transform.position = tampaQuartoTresBlack.transform.position;
            ScoreTomadaTres.scoreNumber += 1;
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
            tampaQuartoTres.transform.position = initialTampaDaTomadaPosition;
            source.clip = incorrect;
            source.Play();
        }
    }

    void LateUpdate()
    {
        if (ScoreTomadaTres.scoreNumber >= 1)
        {
   
            PanelVenceu.SetActive(true);
            timer.SetActive(false);
         
        }
    }
}
