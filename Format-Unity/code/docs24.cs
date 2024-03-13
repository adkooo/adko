using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{

    public GameObject gam;
    private test4 a;
    private test3 b;


    void nn()
    {
        a = GetComponent<test4>();
        b = GetComponent<test3>();

        print(a.a + " [.] " + b.b);

    }


    // Start is called before the first frame update
    void Start()
    {
        nn();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            a.a = 600;
            print(a.a);
        }
    }
}
