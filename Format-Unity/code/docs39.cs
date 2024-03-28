using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;


public class test4 : MonoBehaviour
{

    public GameObject[] a;


    void OnMuseUp()
    {
        print(1);
    }

    void OnMuseEnter()
    {
        print(2);
    }

    void OnMuseExit()
    {
        print(3);
    }

    void OnMuseOver()
    {
        print(4);
        transform.Rotate(0,1,0);
    }

    

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject b in a)
        {
            if (b.tag == "a" )
            {
                b.SetActive (false);
                print(b.name);
            }
        }
    }
   
    // Update is called once per frame
    void Update()
    {
     
    }
   
}   
