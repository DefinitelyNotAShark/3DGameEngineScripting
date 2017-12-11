using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class PortalScript : MonoBehaviour, IActivatable{
    [SerializeField]
    private string nameText;

    public string NameText { get { return nameText; } set { nameText = value; } }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void DoActivate()
    {
        if (StarScript.StarCount == 4)
        {
            if (PortalLight.lightOn == true)
            {
                UsePortal();
            }
            else
            PortalLight.lightOn = true;
            NameText = "It's on! Enter?";
        }
        else
        {
            NameText = StarScript.StarCount + "/4 Crystals.";
        }
    }

    public void UsePortal()
    {
        SceneManager.LoadScene("Scene2");
    }
}
