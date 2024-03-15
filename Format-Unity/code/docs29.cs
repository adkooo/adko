using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test4 : MonoBehaviour
{

    public Light a;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a.intensity = Mathf.Lerp(a.intensity , 0.3f ,0.5f);
    }

}
