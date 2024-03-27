using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test4 : MonoBehaviour
{

    int a = 9;
    

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < a; i++)
        {
            print(i);
        }

        while (a < 15)
        {
            print(a);
            a++;
        }

        do
        {
            print(a);
            a++;
        } while (a < 10);

    }

    // Update is called once per frame
    void Update()
    {
            
    }

}   
