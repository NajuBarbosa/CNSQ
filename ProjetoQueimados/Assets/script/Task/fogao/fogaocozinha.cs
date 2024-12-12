using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fogaocozinha : MonoBehaviour
{
    public Animator animfogao;
    // Start is called before the first frame update
    void Start()
    {
        animfogao = GetComponent<Animator>();
        animfogao.SetBool("aceso", true);
       animfogao.SetBool("apagado", false);
    }

    public void apagacozinha()
    {
        animfogao.SetBool("aceso", false);
        animfogao.SetBool("apagado", true);
    }
    
   
}
