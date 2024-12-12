using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fogao : MonoBehaviour
{

    public GameObject PanelVenceu;
    private Animator animfogaot;
    public GameObject timer;
    public AudioSource audiofogao;
    public AudioSource audiofogo;
    public GameObject visaoaudiofogao;
    void Start()
    {
        audiofogo.Play();
        timer.SetActive(true);
        Timer.time = 20;
        PanelVenceu.SetActive(false);
        animfogaot = GetComponent<Animator>();
       
        animfogaot.SetInteger("liga", 0);
    }


    public void apaga()
    {
        timer.SetActive(false);
        animfogaot.SetInteger("liga", 1);
        if (animfogaot == true)
        {
            GameManager.scoreNumberM++;
        }
        StartCoroutine("tela");
       
    }
    IEnumerator tela()
    {
        audiofogo.Pause();
        yield return new WaitForSeconds(0.6f);
        visaoaudiofogao.SetActive(false);
        PanelVenceu.SetActive(true);
        audiofogao.Play();
    }

  

}


