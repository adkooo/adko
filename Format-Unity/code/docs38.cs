using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;


public class test4 : MonoBehaviour
{

    public GameObject a;

    IEnumerator b()
    {
        yield return new WaitForSeconds(4.5f);
        Destroy(a);
    }


    // Start is called before the first frame update
    void Start()
    {
       a = Instantiate(a , new Vector3(2,4,0),Quaternion.identity);
        StartCoroutine(b());
       
    }
   
    // Update is called once per frame
    void Update()
    {
     
    }
   
}   
