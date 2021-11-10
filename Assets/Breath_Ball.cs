using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breath_Ball : MonoBehaviour
{

    // Start is called before the first frame updatehenlib 
    bool increase = true;
    Vector3 big = new Vector3(2, 2, 2);
    Vector3 small = new Vector3(0, 0, 0);
    void Start()
    {
        InvokeRepeating("breath", 0, 0.05f);
    }

    // Update is called once per frame
    void Update()
    {
        /*float scale = gameObject.transform.localScale.x;
        if (scale >= 2)
        {
            increase = false;
        }
        else if (scale <= 0.1f)
        {
            increase = true;
        }
        if (increase)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, big, 5);
        }
        else
        {
            transform.localScale = Vector3.Lerp(transform.localScale, small, 5);
        }*/
        
    }

    void breath() 
    {
        float scale = gameObject.transform.localScale.x;
        if (scale >= 2)
        {
            increase = false;
        }
        else if (scale <= 0) 
        {
            increase = true;
        }
        if (increase)
        {
            gameObject.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
        }
        else
        {
            gameObject.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
        }
    }
}
