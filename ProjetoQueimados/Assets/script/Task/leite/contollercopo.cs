using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contollercopo : MonoBehaviour
{

    public Animator animacopos;
    // Start is called before the first frame update
    void Start()
    {
        animacopos = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void animacopo()
    {
        animacopos.SetTrigger("vazio");
    }
}
