using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class test : MonoBehaviour
{


    public List<string> aa = new List<string>();
    private List<string> bb = new List<string>();
    public float go = 2f; 

    // Start is called before the first frame update
    void Start()
    {
        var a = "ali";
        int b = 5;
        float c = 5.25F;
        bool d = false;
        var e = new string[2];

        e[0] = "ali";
        e[1] = "Hi";


        var show = e[0] + " " + e[1];

        Debug.Log(show);
        print("ali :)");

        aa.Add("A");
        aa.Add("B");
        aa.Add("C");

        print(aa[0] + " " + aa[1] + " " + aa[2]);


        bb.Add("D");
        bb.Add("E");
        bb.Add("G");

        print(bb[0] + " " + bb[1] + " " + bb[2]);


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(go , 0 , transform.position.z) * Time.deltaTime);
    }
}
