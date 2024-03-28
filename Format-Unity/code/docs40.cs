using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;


public class test4 : MonoBehaviour
{
    /*
    void OnCollisionEnter2D(Collision2D a)
    {
        print("Collision");
    }*/

    void OnCollisionEnter2D(Collision2D a)
    {
        if (a.gameObject.tag == "a")
        {
            print("Collision");
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1200));
        }
        
    }

    void OnCollisionExit2D(Collision2D b)
    {
        print("Collision Exit");
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
