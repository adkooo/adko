using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test4 : MonoBehaviour
{
    public int b = 6;
    void a()
    {
        switch (b)
        {
            case 1:
                print(1);
                break;
            case 2:
                print(2);
                break;
            default:
                print("404");
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        a();
    }

    // Update is called once per frame
    void Update()
    {
     
    }
   
}   
