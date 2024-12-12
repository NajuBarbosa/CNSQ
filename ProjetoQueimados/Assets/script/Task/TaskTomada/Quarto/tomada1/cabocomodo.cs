using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabocomodo : MonoBehaviour
{
    private Animator caboanim;
    // Start is called before the first frame update

    void Start()
    {
        caboanim = GetComponent<Animator>();
        caboanim.SetInteger("mudacabo", 0);
    }
    public void protegecabo() { 

        
            caboanim.SetInteger("mudacabo", 1);
        
    }
}
