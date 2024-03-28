using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test4 : MonoBehaviour
{

    

    void OnGUI()
    {
        if (GUI.Button(new Rect(10 ,10 ,150 ,100),"color red"))
        {
            print("ali");
        }

        GUI.Label(new Rect(100, 300, 100, 100), "test");
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
     
    }
   
}   
