using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_InventoryUI : MonoBehaviour
{
    private Inventory inventory;
    [SerializeField] private UI_Inventory uiInventory;

    private void Start()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
    }

    public void AddEquipment()
    {
        Debug.Log("Equipment added.");

    }

    public void AddConsumable()
    {
        Debug.Log("Consumable added.");

    }

    public void AddMisc()
    {
        Debug.Log("Misc added.");
    }
}
