using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldBoots : MonoBehaviour, ICollectible
{
    public static event HandleGoldBootsCollected OnGoldBootsCollected;
    public delegate void HandleGoldBootsCollected (ItemData itemData);
    public ItemData goldBootsData;

    public void Collect()
    {
        UnityEngine.Debug.Log("You picked up a Gold Boots.");
        OnGoldBootsCollected?.Invoke(goldBootsData);
    }
    
}
