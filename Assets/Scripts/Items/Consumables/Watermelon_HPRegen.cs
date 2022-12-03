using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watermelon_HPRegen : MonoBehaviour, ICollectible
{
    public static event HandleWatermelonCollected OnWatermelonCollected;
    public delegate void HandleWatermelonCollected(ItemData itemData);
    public ItemData watermelonData;

    public void Collect()
    {
        UnityEngine.Debug.Log("You picked up a Watermelon.");
        OnWatermelonCollected?.Invoke(watermelonData);
    }
}
