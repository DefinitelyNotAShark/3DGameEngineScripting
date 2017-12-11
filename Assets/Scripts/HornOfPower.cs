using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HornOfPower : MonoBehaviour, IActivatable {

    [SerializeField]
    private string nameText;
    public string NameText { get { return nameText; } }

    public void DoActivate()
    {
        SceneManager.LoadScene("GameOver");
    }
}
