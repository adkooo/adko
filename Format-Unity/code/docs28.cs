using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test4 : MonoBehaviour
{


    public class MyClass
    {
        public int a = 5;
        public int b; 
        public int c;
        public int d; 

        public MyClass(int f)
        {
            d = f;
        }

        public MyClass()
        {
            b = 6;
            c = 9;
        }
    }



    public  MyClass e = new MyClass();

    public MyClass h = new MyClass(55);



    //public MyClass mm; استفاده در خارج کد

    // Start is called before the first frame update
    void Start()
    {

        

        print(e.a);
        print(h.d);


        //mm.a.a;
        // CancelInvoke();
    }

    // Update is called once per frame
    void Update()
    {

    }

}
