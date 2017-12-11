using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour, IActivatable {

    [SerializeField]
    private string nameText;
    public string NameText { get { return nameText; } }

    public static int StarCount = 0;
    private float rotateNumber = 20f;

    MeshRenderer meshRenderer;
    MeshCollider meshCollider;

	// Use this for initialization
	void Start () {
        meshCollider = GetComponent<MeshCollider>();
        meshRenderer = GetComponent<MeshRenderer>();
	}

    public void DoActivate()
    {
        //stops ability to collide
        meshCollider.enabled = false;
        //makes invisible
        meshRenderer.enabled = false;

        StarCount++;

    }
}
