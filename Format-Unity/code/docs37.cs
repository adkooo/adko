using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;


public class test4 : MonoBehaviour
{

    public Texture2D a;
    public Texture2D b;

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, 500, 300), a);
        GUI.color = Color.magenta;
        GUI.Label(new Rect(100, 300, 100, 100), "test");

        GUI.Box(new Rect(100, 400, 500, 300), b);


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
