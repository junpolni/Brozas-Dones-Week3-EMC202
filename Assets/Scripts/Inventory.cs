using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    
    public static event Action<List<InventoryItem>> OnInventoryChange;

    public List<InventoryItem> inventory = new List<InventoryItem>();
    private Dictionary<ItemData, InventoryItem> itemDictionary = new Dictionary<ItemData, InventoryItem>();

    private void OnEnable()
    {
        // Equipments
        DiamondSword.OnDiamondSwordCollected += AddNonStack;
        Crossbow.OnCrossbowCollected += AddNonStack;
        DiamondPickaxe.OnPickaxeCollected += AddNonStack;
        LeatherArmor.OnLeatherArmorCollected += AddNonStack;
        GoldBoots.OnGoldBootsCollected += AddNonStack;

        // Consumables
        Chicken_HPRegen.OnChickenCollected += Add;
        Cookie_RESIncrease.OnCookieCollected += Add;
        RedPotion_ATKBuff.OnRedPotionCollected += Add;
        Watermelon_HPRegen.OnWatermelonCollected += Add;
        GrayPotion_CRBuff.OnGrayPotionCollected += Add;

        // Misc
        BrownBook.OnBrownBookCollected += AddNonStack;
        Painting.OnPaintingCollected += AddNonStack;
        Sign.OnSignCollected += AddNonStack;
        Disc.OnDiscCollected += AddNonStack;
        FlowerPot.OnFlowerPotCollected += AddNonStack;

    }
    
    public void Add(ItemData itemData)
    {
        if(itemDictionary.TryGetValue(itemData, out InventoryItem item))
        {
            item.AddToStack();
            Debug.Log($"{item.itemData.displayName} total stack is now {item.stackSize}");
            OnInventoryChange?.Invoke(inventory);
        }
        else
        {
            InventoryItem newItem = new InventoryItem(itemData);
            inventory.Add(newItem);
            itemDictionary.Add(itemData, newItem);
            Debug.Log($"Added {itemData.displayName} to the inventory for the first time.");
            OnInventoryChange?.Invoke(inventory);
        }
    }

    public void Remove(ItemData itemData)
    {
        if(itemDictionary.TryGetValue(itemData, out InventoryItem item))
        {
            item.RemoveFromStack();
            if(item.stackSize == 0)
            {
                inventory.Remove(item);
                itemDictionary.Remove(itemData);
            }
        }
    }

    public void AddNonStack(ItemData itemData)
    {
        if(itemDictionary.TryGetValue(itemData, out InventoryItem item))
        {
            Debug.Log($"{item.itemData.displayName} is duplicated in the inventory.");
            OnInventoryChange?.Invoke(inventory);
        }
        else
        {
            InventoryItem newItem = new InventoryItem(itemData);
            inventory.Add(newItem);
            itemDictionary.Add(itemData, newItem);
            Debug.Log($"Added {itemData.displayName} to the inventory for the first time.");
            OnInventoryChange?.Invoke(inventory);
        }
    }
}
