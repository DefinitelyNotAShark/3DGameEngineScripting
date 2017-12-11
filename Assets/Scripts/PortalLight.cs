using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalLight : MonoBehaviour {

    public static bool lightOn = false;
	
	// Update is called once per frame
	void Update () {
        CheckLight();
	}

    private void CheckLight()
    {
        if (lightOn)
        {
            GetComponent<Light>().enabled = true;
        }
    }
}
