using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class ItemData : ScriptableObject
{
    public string displayName;
    public string itemDescription;
    public Sprite icon;
    public ItemType Type;
}

public enum ItemType
{
    Consumables,
    Equipment,
    Miscellaneous,
    
}