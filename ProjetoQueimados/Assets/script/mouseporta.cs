using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mouseporta : MonoBehaviour
{
   
    public string ProximaFase;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  // void OnMouseEnter()
   // {
    //    Debug.Log("entrou");
  //  }

    void OnMouseDown()
    {
       // if (Input.GetTouch) {
      // for (int i = 0; 1 <Input.touchCount; i++)
       // { 
            SceneManager.LoadScene(ProximaFase);
            Debug.Log("tocou");
          // }
        //
    }

    // void OnMouseExit()
   // {
        
    //}

}
