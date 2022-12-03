using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : MonoBehaviour, ICollectible
{
    public static event HandleCrossbowCollected OnCrossbowCollected;
    public delegate void HandleCrossbowCollected (ItemData itemData);
    public ItemData crossbowData;

    public void Collect()
    {
        UnityEngine.Debug.Log("You picked up a Crossbow.");
        OnCrossbowCollected?.Invoke(crossbowData);
    }
    
}
