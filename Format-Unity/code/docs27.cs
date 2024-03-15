using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test4 : MonoBehaviour
{
    public GameObject a;


    void b()
    {
        Instantiate(a ,new Vector3(0,4,0), Quaternion.identity);
    }


    // Start is called before the first frame update
    void Start()
    {
        Invoke("b" , 4F);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
