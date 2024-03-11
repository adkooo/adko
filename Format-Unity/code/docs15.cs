using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test4 : MonoBehaviour
{


    public GameObject a;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
      

        if (Input.GetKey(KeyCode.D)) 
        {
            Destroy(a.GetComponent<SpriteRenderer>());
        }

        /*
        if (Input.GetKey(KeyCode.D))
        {
            Destroy(GetComponent<SpriteRenderer>());
        }
        */


    }
}
