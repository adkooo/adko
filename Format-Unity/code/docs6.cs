using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{

    public bool a = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            a = !a;

           // a = true;
        }

        if (a)
        {
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime);
        }
    }
}
