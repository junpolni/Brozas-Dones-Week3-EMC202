using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Watermelon_HPRegen : MonoBehaviour, ICollectible
{
    public static event HandleWatermelonCollected OnWatermelonCollected;
    public delegate void HandleWatermelonCollected(ItemData itemData);

    public static event HandleWatermelonConsumed OnWatermelonConsumed;
    public delegate void HandleWatermelonConsumed(ItemData itemData);
    
    public ItemData watermelonData;

    public void Collect()
    {
        UnityEngine.Debug.Log("You picked up a Watermelon.");
        OnWatermelonCollected?.Invoke(watermelonData);
    }

    public void Consume()
    {
        UnityEngine.Debug.Log("You consumed a Watermelon.");
        OnWatermelonConsumed?.Invoke(watermelonData);
    }
}
