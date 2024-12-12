using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controleDoSom : MonoBehaviour
{
    private bool somON;
    [SerializeField] Image soundOFF;
    [SerializeField] Image soundON;


    void Start()
    {
        OnOff();
    }

    public void volumeDoJogo()
    {
        somON = !somON;
        if(somON == false)
        {
            AudioListener.volume = 1;
        }
        else
        {
            AudioListener.volume = 0;
        }

        OnOff();
    }

    private void OnOff()
    {
        if(somON == true)
        {
            soundON.enabled = true;
            soundOFF.enabled = false;
        }
        else
        {
            soundON.enabled = false;
            soundOFF.enabled = true;
        }
    }

}
