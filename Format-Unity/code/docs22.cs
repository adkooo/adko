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
        float c = Input.GetAxis("Vertical");
        float f = Input.GetAxis("Horizontal");
        float g = f * a;
        float e = c * a;

        transform.position = new Vector3(g, e, 0);

        b.text = "vale : " + e.ToString("F2") + " [] " + g.ToString("F2");
    }
}
