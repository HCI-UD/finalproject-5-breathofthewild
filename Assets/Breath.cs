using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Breath : MonoBehaviour
{
    List<UnityEngine.XR.InputDevice> inputDevices = new List<UnityEngine.XR.InputDevice>();
    public SteamVR_Action_Boolean SphereOnOff;
    // a reference to the hand
    public SteamVR_Input_Sources handType;
    public SteamVR_Action_Boolean AButton = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("BreathIn");
    public SteamVR_Action_Boolean BButton = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("BreathOut");
    // Start is called before the first frame update

    void Start()
    {
        //InvokeRepeating("breath", 0, 0.05f);
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        UnityEngine.XR.InputDevices.GetDevices(inputDevices);

    }

    // Update is called once per frame
    void Update()
    {
        float step = 0.01f;
        float scale = gameObject.transform.localScale.x;
        //bool AButton,BButton;
        /*if (AButton.GetState(SteamVR_Input_Sources.Any) && scale > 0) {
            Debug.Log("A");
            gameObject.transform.localScale -= new Vector3(0.005f, 0.005f, 0.005f);
        }
        else if (BButton.GetState(SteamVR_Input_Sources.Any) && scale < 1.5)
        {
            Debug.Log("B");
            gameObject.transform.localScale += new Vector3(0.005f, 0.005f, 0.005f);
        }*/
        /*foreach (var device in inputDevices)
        {
            if (device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.primaryButton, out AButton) && AButton && scale < 2)
            {
                gameObject.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
                Debug.Log("Triggered");
            }
            else if (device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.secondaryButton, out BButton) && BButton && scale > 0)
            {
                gameObject.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
                Debug.Log("Triggered");
            }
            //Debug.Log(string.Format("Device found with name '{0}' and role '{1}'", device.name, device.role.ToString()));
        }*/
        if (Input.GetKey(KeyCode.I) && scale < 1.5)
        {
            gameObject.transform.localScale += new Vector3(step, step, step);
            Debug.Log("I");
        }
        else if (Input.GetKey(KeyCode.K) && scale > 0)
        {
            gameObject.transform.localScale -= new Vector3(step, step, step);
        }
        GameObject breathText = GameObject.FindGameObjectWithTag("breathBall");
        float comp_scale = breathText.transform.localScale.x;
        float diff = Mathf.Abs(scale - comp_scale)*2;
        Color c = new Vector4(diff, 1-diff, 0);
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", c);
    }

}
