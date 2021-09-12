using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalNode : MonoBehaviour
{
    public Sprite none;
    public Sprite left;
    public Sprite right;
    public string current;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        switchsprite();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void switchsprite()
    {
        if(current == "left")
        {
            sr.sprite = left;
        }
        else if(current == "right")
        {
            sr.sprite = right;
        }
        else
        {
            sr.sprite = none;
        }
    }
}
