using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tast4 : MonoBehaviour
{


    //public GameObject[] a;
    public GameObject a;

    // Start is called before the first frame update
    void Start()
    {
        a = GameObject.FindGameObjectWithTag("a");
        //a = GameObject.FindGameObjectWithTag("a");
        //  print(a [0].name);
        print(a.name);

        /*
        for (int i = 0; i < a.length; i++)
        {
            print(a[i].name);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
