using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leitetasck : MonoBehaviour
{
    public GameObject PanelVenceu;
    public float tempo = 5f;
    public float tempomaximo = 5f;
    public float time = 5;
    public Image barratempo;
    private bool beber;
    private contollercopo copocontroller;
    public Text podebeber;
    public Text leiteText;
    public AudioSource muitobem;
    public AudioSource Som_beberleite;

    //copo da mesa
    public GameObject copocheio;
    public GameObject copovazio;
    bool venceutask;
    // Start is called before the first frame update
    void Start()
    {
        venceutask = false;
        copocheio.SetActive(true);
        copovazio.SetActive(false);
        PanelVenceu.SetActive(false);
        copocontroller = FindObjectOfType<contollercopo>();
       // beber = false;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        tempo = time;
        leiteText.text = time.ToString();
        if(time <= 0)
        {
             time = 0;
             tempo = 0;
            leiteText.text = "0".ToString();
        }
        if (time > 0)
        {
            beber = false;
        }
        if (time <= 0)
        {
            beber = true;
            podebeber.text = " Pode Beber!".ToString();
            /*copocheio.SetActive(false);
            copovazio.SetActive(true);*/
        }


        /*if(venceutask == true)
        {
            copocheio.SetActive(false);
            copovazio.SetActive(true);
        }*/
        Updatebarratempo();
    }

    private void Updatebarratempo()
    {
        barratempo.fillAmount = tempo / tempomaximo;
    }
    public void beberleite()
    {

        Debug.Log("clicou");
        if(beber == true)
        {
            /*copocheio.SetActive(false);
            copovazio.SetActive(true);*/
            venceutask = true;
            Som_beberleite.Play();
            Debug.Log("invoca");
            Invoke("copoplay",0);
            Invoke("panelvitoria", 2.9f);
        }
    }

    void copoplay()
    {
        copocontroller.animacopo();
    }

    private void panelvitoria()
    {
        copocheio.SetActive(false);
        copovazio.SetActive(true);
        GameManager.scoreNumberM++;
        PanelVenceu.SetActive(true);
        muitobem.Play();
    }
}
