using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    public enum ItemType 
    {
        Equipment,
        Misc,
        Consumable,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Equipment:    return ItemAssets.Instance.EquipmentSprite;
            case ItemType.Consumable:   return ItemAssets.Instance.ConsumableSprite;
            case ItemType.Misc:         return ItemAssets.Instance.MiscSprite;
        }
    }
}
