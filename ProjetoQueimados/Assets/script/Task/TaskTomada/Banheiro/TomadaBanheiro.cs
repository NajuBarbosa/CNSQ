using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TomadaBanheiro : MonoBehaviour
{
    public GameObject tampaBanheiro, tampaBanheiroBlack;

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
        ScoreBanheiro.scoreNumber = 0;
        initialTampaDaTomadaPosition = tampaBanheiro.transform.position;
    }
    public void DragTampa()
    {
        tampaBanheiro.transform.position = Input.mousePosition;
    }
    public void DropTampa()
    {
        float distance = Vector3.Distance(tampaBanheiro.transform.position, tampaBanheiroBlack.transform.position);
        if (distance < 50)
        {
            tampaBanheiro.transform.position = tampaBanheiroBlack.transform.position;
            ScoreBanheiro.scoreNumber += 1;
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
            tampaBanheiro.transform.position = initialTampaDaTomadaPosition;
            source.clip = incorrect;
            source.Play();
        }
    }

    void LateUpdate()
    {
        if (ScoreBanheiro.scoreNumber >= 1)
        {
            //Destroy(timer);
            timer.SetActive(false);
            PanelVenceu.SetActive(true);
        }

    }
}
