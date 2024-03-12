using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test4 : MonoBehaviour
{


    public float a;
    public Text b;
 

    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        float c = Input.GetAxis("Horizontal");
        float e = c * a;
        transform.position = new Vector3(e , 0 , 0);
        b.text = "vale : " + c.ToString("F2");
    }
}
