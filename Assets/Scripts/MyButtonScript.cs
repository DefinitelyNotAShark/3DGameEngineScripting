﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MyButtonScript : MonoBehaviour {

    public Button myButton;
	// Use this for initialization
	void Start () {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(OnClick);
	}

    void OnClick()
    {
        SceneManager.LoadScene("Scene1");
    }
}
