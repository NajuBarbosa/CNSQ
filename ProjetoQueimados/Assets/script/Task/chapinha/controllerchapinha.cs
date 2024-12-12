using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerchapinha : MonoBehaviour
{
   
    public Animator animchapinha;
    // Start is called before the first frame update
    void Start()
    {
              animchapinha = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void animachapa()
    {
        animchapinha.SetTrigger("desligou");
    }

   
}
