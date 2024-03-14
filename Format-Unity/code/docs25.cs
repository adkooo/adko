using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test4 : MonoBehaviour
{

    public Rigidbody2D b;

    public Vector3 c;

    // Start is called before the first frame update
    void Start()
    {
       // Destroy(gameObject , 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            Rigidbody2D a;
            //a = Instantiate(b) as Rigidbody2D;
            //a = Instantiate(b, new Vector3  (0 , 5 , 0) ,new Quaternion(0,0,0,0)) as Rigidbody2D;
            a = Instantiate(b, c, new Quaternion(0, 0, 0, 0)) as Rigidbody2D;

        }
    }
}
