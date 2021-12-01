using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("breath", 0, 0.05f);
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        float scale = gameObject.transform.localScale.x;
        if (Input.GetKey(KeyCode.I) && scale < 2)
        {
            gameObject.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
        }
        else if (Input.GetKey(KeyCode.K) && scale > 0)
        {
            gameObject.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
        }
        GameObject breathText = GameObject.FindGameObjectWithTag("breathBall");
        float comp_scale = breathText.transform.localScale.x;
        float diff = Mathf.Abs(scale - comp_scale)*2;
        Color c = new Vector4(diff, 1-diff, 0);
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", c);
    }

    void breath()
    {
        
    }
}
