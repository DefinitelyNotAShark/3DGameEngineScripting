using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : MonoBehaviour, IActivatable {

    [SerializeField]
    private string nameText;

    private InventoryMenu inventoryMenu;
    private MeshRenderer meshRenderer;
    private Collider collider;

    public string NameText { get { return nameText; } }


    public void DoActivate()

    {
        //this adds item to inventory and makes it invisible
        inventoryMenu.PlayerInventory.Add(this);
        collider.enabled = false;
        meshRenderer.enabled = false;
    }

    void Start()

    {
        //instantaniatevars
        meshRenderer = GetComponent<MeshRenderer>();
        collider = GetComponent<Collider>();
        inventoryMenu = FindObjectOfType<InventoryMenu>();
    }

}


