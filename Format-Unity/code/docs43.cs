using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class test4 : MonoBehaviour
{

  

    void OnGUI()
    {
        if (GUI.Button (new Rect(10,20,100,50),"Go =>"))
        {
            //Application.LoadLevel("Go");
            SceneManager.LoadScene("Go");

        }
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
