using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test4 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.E))
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        */

        if (Input.GetKeyUp(KeyCode.E))
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = !gameObject.GetComponent<SpriteRenderer>().enabled;
        }
    }
}
