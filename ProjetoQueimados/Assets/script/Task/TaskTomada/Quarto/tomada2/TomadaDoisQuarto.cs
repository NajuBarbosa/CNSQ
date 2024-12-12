using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TomadaDoisQuarto : MonoBehaviour
{
    public GameObject tampaQuartoDois, tampaQuartoDoisBlack;

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
        ScoreDoisTomada.scoreNumber = 0;
        initialTampaDaTomadaPosition = tampaQuartoDois.transform.position;
    }
    public void DragTampa()
    {
        tampaQuartoDois.transform.position = Input.mousePosition;
    }
    public void DropTampa()
    {
        float distance = Vector3.Distance(tampaQuartoDois.transform.position, tampaQuartoDoisBlack.transform.position);
        if (distance < 50)
        {
            tampaQuartoDois.transform.position = tampaQuartoDoisBlack.transform.position;
            ScoreDoisTomada.scoreNumber += 1;
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
            tampaQuartoDois.transform.position = initialTampaDaTomadaPosition;
            source.clip = incorrect;
            source.Play();
        }
    }

    void LateUpdate()
    {
        if (ScoreDoisTomada.scoreNumber >= 1)
        {
            //Destroy(timer);
            timer.SetActive(false);
            PanelVenceu.SetActive(true);

        }
    }
}
