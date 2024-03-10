using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{


    public GameObject a;


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(a.activeSelf);
        Debug.Log(a.activeSelf); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // a.SetActive(false);
            a.SetActive(!a.activeSelf);
        }
    }
}
