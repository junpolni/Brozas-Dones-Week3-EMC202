using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondPickaxe : MonoBehaviour, ICollectible
{
    public static event HandleDiamondPickaxeCollected OnPickaxeCollected;
    public delegate void HandleDiamondPickaxeCollected (ItemData itemData);
    public ItemData pickaxeData;

    public void Collect()
    {
        UnityEngine.Debug.Log("You picked up a Pickaxe.");
        OnPickaxeCollected?.Invoke(pickaxeData);
    }
    
}
