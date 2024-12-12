using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TomadaDaSala : MonoBehaviour
{
    public GameObject PanelVenceu;
    private Animator animcabotesk;
    public GameObject timer;
    public AudioSource vitoria;
    public AudioSource choque;
    public GameObject audiovisao;
    void Start()
    {
        choque.Play();
        timer.SetActive(true);
        Timer.time = 20;
        PanelVenceu.SetActive(false);
        animcabotesk = GetComponent<Animator>();

        animcabotesk.SetInteger("cabomuda", 0);
    }


    public void arrumacabo()
    {

        timer.SetActive(false);
        animcabotesk.SetInteger("cabomuda", 1);
        if (animcabotesk == true)
        {
            GameManager.scoreNumberM++;
        }


        StartCoroutine("cabo");


    }
    IEnumerator cabo()
    {
        choque.Pause();
        // GameManager.scoreNumberM++;
        yield return new WaitForSeconds(0.7f);
        audiovisao.SetActive(false);
        PanelVenceu.SetActive(true);
        vitoria.Play();
    }


}
