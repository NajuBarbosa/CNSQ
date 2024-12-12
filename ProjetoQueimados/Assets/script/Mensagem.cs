using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mensagem : MonoBehaviour
{
    public Text texto;
    [Range(0.1f,10.0f)] public float distancia = 3;

    private GameObject jogador;

    // Start is called before the first frame update
    void Start()
    {
        texto.enabled = false;
        jogador = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,jogador.transform.position) < 2)
        {
            texto.enabled = true;
        }
        else
        {
            texto.enabled = false;
        }
    }
}
