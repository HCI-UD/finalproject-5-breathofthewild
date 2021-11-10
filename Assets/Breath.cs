using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            gameObject.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }
        else if (Input.GetKey(KeyCode.K)) 
        {
            gameObject.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        }
    }
}
