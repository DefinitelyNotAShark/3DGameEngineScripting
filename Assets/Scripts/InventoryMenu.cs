using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryMenu : MonoBehaviour {

    [SerializeField]
    private string nameText;

    [SerializeField]
    private GameObject inventoryMenuPanel;
    private InventoryMenu inventoryMenu;
    private Collider collider;
    private MeshRenderer meshRenderer;

    private List<InventoryObject> playerInventory;

    #region properties
    public List<InventoryObject> PlayerInventory { get { return playerInventory; } }
    #endregion

    void Awake()//happens before start. Initialize inventory list early!!!
    {
        playerInventory = new List<InventoryObject>();
    }

    // Use this for initialization
    void Start () {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        inventoryMenu = FindObjectOfType<InventoryMenu>();
        HideMenu();
	}
	
	// Update is called once per frame
	void Update () {
        HandleInput();
	}

    private void HandleInput()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (IsMenuOpen)
                HideMenu();
            else
                ShowMenu();
        }
    }

    private void ShowMenu()
    {
        inventoryMenuPanel.SetActive(true);
        UpdateCursor();
    }

    private void HideMenu()
    {
        inventoryMenuPanel.SetActive(false);
        UpdateCursor();
    }

    private bool IsMenuOpen
    {
        get
        {
            return inventoryMenuPanel.activeSelf;
        }
    }

    private void UpdateCursor()
    {
        if (IsMenuOpen)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
