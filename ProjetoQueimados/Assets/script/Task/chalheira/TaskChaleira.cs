using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TaskChaleira : MonoBehaviour
{
    public GameObject PanelVenceu;
    public float tempo = 5f;
    public float tempomaximo = 5f;
    public float time = 5;
    public Image barratempo;
    private bool beber;
    private ControllerChaleira chacontroller;
    public Text textinfo;
    public Text tempoText;
    public AudioSource muitobem;

    public GameObject visaoaudiochaleira;
    //copo da mesa
    public GameObject chaliga;
    public GameObject chadesliga;
    bool venceutask;
    bool desligou;
    // Start is called before the first frame update
    void Start()
    {
        desligou = false;
        venceutask = false;
        chaliga.SetActive(true);
        chadesliga.SetActive(false);
        PanelVenceu.SetActive(false);
        chacontroller = FindObjectOfType<ControllerChaleira>();
        // beber = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (desligou == true)
        {
            time -= Time.deltaTime;
            tempo = time;
            tempoText.text = time.ToString();
            if (time <= 0)
            {
                time = 0;
                tempo = 0;
                tempoText.text = "0".ToString();
            }

            if (time <= 0)
            {
                beber = true;
                textinfo.text = " Está frio!".ToString();
                
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
            visaoaudiochaleira.SetActive(false);
            venceutask = true;

            Debug.Log("invoca");
            Invoke("chaplay", 0);
            Invoke("panelvitoria", 5.5f);
        }
    }

    void chaplay()
    {
        chacontroller.animacha();
    }

    private void panelvitoria()
    {
        chaliga.SetActive(false);
        chadesliga.SetActive(true);
        GameManager.scoreNumberM++;
        PanelVenceu.SetActive(true);
        muitobem.Play();
    }
}

