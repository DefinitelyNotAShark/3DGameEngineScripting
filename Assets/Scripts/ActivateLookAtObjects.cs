using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLookAtObjects : MonoBehaviour {
    //this script goes on FPC camera
    [SerializeField]
    float maxDistanceToCheckForObjects = 4.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
        Debug.DrawRay(transform.position, transform.forward * maxDistanceToCheckForObjects, Color.red);

        RaycastHit raycastHit;
        //this checks if the raycast hits something
        if(Physics.Raycast(transform.position, transform.forward, out raycastHit, maxDistanceToCheckForObjects))
        {
            Debug.Log(raycastHit.transform.name + " is being looked at.");

            IActivatable lookedAtObject = raycastHit.transform.GetComponent<IActivatable>();

            if(lookedAtObject != null)
            {
                Debug.Log("this is an iactivatable");
            }
        }
        
	}
}
