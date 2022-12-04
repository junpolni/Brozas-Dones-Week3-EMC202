using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryControl : MonoBehaviour
{
    private ItemDragHandler draggableItem;

    [SerializeField] DropItemArea dropItemArea;
    [SerializeField] private Chicken_HPRegen chickenHPRegen;

    void Start()
    {
        Debug.Log("Inventory");

        dropItemArea.OnDropEvent += DropItemOutsideUI;
    }

    private void DropItemOutsideUI()
    {
        if (draggableItem == null) return;

        chickenHPRegen.Consume();

        Debug.Log("Item Dropped.");

    }



    
}