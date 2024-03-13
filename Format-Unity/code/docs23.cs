using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test4 : MonoBehaviour
{
    public Image a; // Changed from GUITexture to Image
    public Sprite b; // Changed from Texture2D to Sprite
    public Sprite c; // Changed from Texture2D to Sprite
    public Sprite d; // Changed from Texture2D to Sprite
    public Sprite e; // Changed from Texture2D to Sprite

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool v = Input.GetButtonDown("Jump");
        bool o = Input.GetButton("Jump");
        bool i = Input.GetButtonUp("Jump");

        if (v)
        {
            a.sprite = c; // Changed texture to sprite

        }
        else if (o)
        {
            a.sprite = e; // Changed texture to sprite
        }
        else if (i)
        {
            a.sprite = d; // Changed texture to sprite
        }
        else
        {
            a.sprite = b; // Changed texture to sprite
        }

        gameObject.GetComponent<Text>().text = " " + v + " " + o + " " + i; // Changed from GUIText to Text
    }
}
