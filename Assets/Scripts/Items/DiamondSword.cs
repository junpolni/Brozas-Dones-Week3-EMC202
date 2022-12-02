using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondSword : MonoBehaviour, ICollectible
{
    public static event HandleDiamondSwordCollected OnDiamondSwordCollected;
    public delegate void HandleDiamondSwordCollected(ItemData itemData);
    public ItemData diamondSwordData;

    public void Collect()
    {
        UnityEngine.Debug.Log("You picked up a Diamond Sword.");
        OnDiamondSwordCollected?.Invoke(diamondSwordData);
    }
    
}
