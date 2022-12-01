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
        inventory.AddItem(new Item { itemType = Item.ItemType.Equipment, amount = 1});
        Debug.Log("Equipment added.");

    }

    public void AddConsumable()
    {
        inventory.AddItem(new Item { itemType = Item.ItemType.Consumable, amount = 1});
        Debug.Log("Consumable added.");

    }

    public void AddMisc()
    {
        inventory.AddItem(new Item { itemType = Item.ItemType.Misc, amount = 1});
        Debug.Log("Misc added.");
    }
}
