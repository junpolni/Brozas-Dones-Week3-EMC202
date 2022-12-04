using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryControl : MonoBehaviour
{
    private ItemDragHandler draggableItem;

    [SerializeField] DropItemArea dropItemArea;
    [SerializeField] private DiamondSword diamondSword;
    

    void Start()
    {
        Debug.Log("Inventory");

        dropItemArea.OnDropEvent += DropItemOutsideUI;
    }

    private void DropItemOutsideUI()
    {
        if (draggableItem == null) return;

        Destroy(diamondSword);

        Debug.Log("Item Dropped.");

    }



    
}