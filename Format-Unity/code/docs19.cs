using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test4 : MonoBehaviour
{


    enum a {a1,a2,a3,a4};
 

    // Start is called before the first frame update
    void Start()
    {
        a b;
        b = a.a1;
        print(c(b));
    }
    
    // Update is called once per frame
    void Update()
    {

    }

    string c (a s)
    {
        if (s == a.a1)
        {
            print("a1");
        }

        if (s == a.a2)
        {
            print("a2");
        }

        if (s == a.a3)
        {
            print("a3");
        }
        if (s == a.a4)
        {
            print("a4");
        }
        return "0";
    }
}
