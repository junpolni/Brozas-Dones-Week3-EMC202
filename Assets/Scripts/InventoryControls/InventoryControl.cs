using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryControl : MonoBehaviour
{
    private Inventory inventory;

    void Start()
    {
        inventory = new Inventory();

        Debug.Log("Inventory");
    }

    
}