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
}
