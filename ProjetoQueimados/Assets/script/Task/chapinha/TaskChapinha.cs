using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TaskChapinha : MonoBehaviour
{
    public GameObject PanelVenceu;
    public float tempo = 5f;
    public float tempomaximo = 5f;
    public float time = 5;
    public Image barratempo;
    private bool beber;
    private controllerchapinha copocontroller;
    public Text podebeber;
    public Text leiteText;
    public AudioSource muitobem;
   

    //copo da mesa
    public GameObject copocheio;
    public GameObject copovazio;
    bool venceutask;
    bool desligou;
    // Start is called before the first frame update
    void Start()
    {
        desligou = false;
        venceutask = false;
        copocheio.SetActive(true);
        copovazio.SetActive(false);
        PanelVenceu.SetActive(false);
        copocontroller = FindObjectOfType<controllerchapinha>();
        // beber = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (desligou == true)
        {
            time -= Time.deltaTime;
            tempo = time;
            leiteText.text = time.ToString();
            if (time <= 0)
            {
                time = 0;
                tempo = 0;
                leiteText.text = "0".ToString();
            }
            
            if (time <= 0)
            {
                beber = true;
                podebeber.text = " Está frio!".ToString();
                
            }


           
            Updatebarratempo();
        }
    }

    private void Updatebarratempo()
    {
        barratempo.fillAmount = tempo / tempomaximo;
    }
    public void beberleite()
    {
        desligou = true;
        Debug.Log("clicou");
        if (desligou == true)
        {
            
            venceutask = true;
           
            Debug.Log("invoca");
            Invoke("copoplay", 0);
            Invoke("panelvitoria", 5.5f);
        }
    }

    void copoplay()
    {
        copocontroller.animachapa();
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