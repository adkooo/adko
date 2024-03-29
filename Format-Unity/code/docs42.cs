using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;


public class test4 : MonoBehaviour
{

    public GameObject a;
   // public AudioSource c;

    void OnGUI()
    {
        if (GUI.Button (new Rect(10,20,100,50),"Play"))
        {
            a.GetComponent<AudioSource>().Play(); 
        }
    }

    /*
    void b()
    {
        c.Play();
        c.pitch = Random.Range(0.1f, 1.9F);
    }*/

    // Start is called before the first frame update
    void Start()
    {
        OnGUI();
        //b();
    }
   
    // Update is called once per frame
    void Update()
    {
     
    }
   
}   
