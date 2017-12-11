using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateLookAtObjects : MonoBehaviour {

    //this script goes on FPC camera
    [SerializeField]
    float maxDistanceToCheckForObjects = 4.0f;

    [SerializeField]
    private Text lookedAtObjectsText;

    private IActivatable lookedAtObject;
	// Update is called once per frame
	void Update ()
    {
        UpdateLookedAtObjects();
        UpdateLookedAtObjectText();
        HandleInput();
	}


    private void HandleInput()
    {
        if (lookedAtObject != null && Input.GetButtonDown("Activate"))
        {
            Debug.Log("this is an iactivatable");
            lookedAtObject.DoActivate();

        }
    }


    private void UpdateLookedAtObjects()
    {
        Debug.DrawRay(transform.position, transform.forward * maxDistanceToCheckForObjects, Color.red);

        RaycastHit raycastHit;
        //this checks if the raycast hits something
        if (Physics.Raycast(transform.position, transform.forward, out raycastHit, maxDistanceToCheckForObjects))
        {
            Debug.Log(raycastHit.transform.name + " is being looked at.");

            lookedAtObject = raycastHit.transform.GetComponent<IActivatable>();       
        }
        else
        {
            lookedAtObject = null;
        }
    }

    private void UpdateLookedAtObjectText()
    {
        if(lookedAtObject == null)
        {
            lookedAtObjectsText.text = string.Empty;

        }
        else
        {
            lookedAtObjectsText.text = lookedAtObject.NameText;
        }
    }



}
