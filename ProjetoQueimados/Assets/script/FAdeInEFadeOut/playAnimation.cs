using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnimation : MonoBehaviour
{
    public Animator animator;
    

    public void PlayMain()
    {
        animator.SetTrigger("main");
    }
    public void PlayCredits()
    {
        animator.SetTrigger("credits");
    }
}
