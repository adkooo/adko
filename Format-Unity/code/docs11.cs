using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test4 : MonoBehaviour
{

    public int a = 5;


    int b (int c)
    {
        return a * c;
    }

    // Start is called before the first frame update
    void Start()
    {
        print(b(5));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
