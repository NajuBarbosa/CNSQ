using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentPersonagem : MonoBehaviour
{
    private int AuxiliaDirecao;
    private float speed;
    private Animator AnimPlay;
    void Start()
    {
        AnimPlay = GetComponent<Animator>();
        speed = 5f;
    }


    void FixedUpdate()
    {
        if (AuxiliaDirecao != 0)
        {
            transform.Translate(speed * Time.deltaTime * AuxiliaDirecao, 0, 0);
        }
        if (AuxiliaDirecao < 0)
        {
            AnimPlay.SetTrigger("Esquerda");
            // GetComponent<SpriteRenderer>().flipX = true;
        }
        if (AuxiliaDirecao > 0)
        {
            AnimPlay.SetTrigger("Direita");
            //GetComponent<SpriteRenderer>().flipX = false;

        }


        if (AuxiliaDirecao == 0)
        {
            AnimPlay.SetTrigger("Idle");
        }

    }

    public void TouchHorizontal(int direcao)
    {
        AuxiliaDirecao = direcao;
    }
    }



