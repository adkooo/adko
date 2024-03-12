using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test4 : MonoBehaviour
{


    public Light a;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.E))
        {
            //a.GetComponent<Light>().enabled = false;

            a.GetComponent<Light>().enabled = !a.GetComponent<Light>().enabled;
        }
    }
}
