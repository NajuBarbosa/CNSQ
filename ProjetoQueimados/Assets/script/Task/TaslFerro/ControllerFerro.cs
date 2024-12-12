using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerFerro : MonoBehaviour
{
    public Animator animferro;
    // Start is called before the first frame update
    void Start()
    {
        animferro = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void animaferro()
    {
        animferro.SetTrigger("ferrodesliga");
    }
}
