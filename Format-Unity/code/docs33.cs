using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test4 : MonoBehaviour
{


    public SpriteRenderer a;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            a.color = Color.black;
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            a.color = Color.white;
        }
    }
   
}   
