using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerChaleira : MonoBehaviour
{
    public Animator animcha;
    // Start is called before the first frame update
    void Start()
    {
        animcha = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void animacha()
    {
        animcha.SetTrigger("desligacha");
    }


}
