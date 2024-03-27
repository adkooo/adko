using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test4 : MonoBehaviour
{


    public float b = 400;

    void a()
    {
        // no code void
    }
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            
    }
    void OnMouseDown()
    {
        //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1000));
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, b));

    }

}   
