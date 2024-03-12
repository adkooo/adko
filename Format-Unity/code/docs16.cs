using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test4 : MonoBehaviour
{


    public GameObject a;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {

           // Destroy(a , 5F);

            Destroy(a.GetComponent<SpriteRenderer>(), 5F);

    }
}
