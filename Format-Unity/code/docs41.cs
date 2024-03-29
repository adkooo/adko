using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;


public class test4 : MonoBehaviour
{
  


    void OnCollisionStay2D(Collision2D a)
    {
        print("OnCollisionStay2D");
    }

    void OnTriggerEnter2D(Collider2D b)
    {
        print("OnTriggerEnter2D");
    }

    void OnTriggerExit2D(Collider2D c)
    {
        print("OnTriggerExit2D");
    }

    void OnTriggerStay2D(Collider2D e)
    {
        print("OnTriggerStay2D");
    }




    // Start is called before the first frame update
    void Start()
    {

    }
   
    // Update is called once per frame
    void Update()
    {
     
    }
   
}   
