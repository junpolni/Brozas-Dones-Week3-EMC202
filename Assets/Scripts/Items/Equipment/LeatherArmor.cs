using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherArmor : MonoBehaviour, ICollectible
{
    public static event HandleLeatherArmorCollected OnLeatherArmorCollected;
    public delegate void HandleLeatherArmorCollected (ItemData itemData);
    public ItemData leatherArmorData;

    public void Collect()
    {
        UnityEngine.Debug.Log("You picked up a Leather Armor.");
        OnLeatherArmorCollected?.Invoke(leatherArmorData);
    }
    
}
