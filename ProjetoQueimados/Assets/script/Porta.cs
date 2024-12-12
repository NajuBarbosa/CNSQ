using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{
    void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
