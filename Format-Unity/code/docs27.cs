using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test4 : MonoBehaviour
{
    public GameObject a;


    void b()
    {
        float c = Random.Range(-2.0f,2.0f);
        Instantiate(a, new Vector3(c, 4, 0),Quaternion.identity);

    }


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("b",2,1);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
