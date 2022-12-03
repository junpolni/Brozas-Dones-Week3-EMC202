using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disc : MonoBehaviour, ICollectible
{
    public static event HandleDiscCollected OnDiscCollected;
    public delegate void HandleDiscCollected(ItemData itemData);
    public ItemData discData;

    public void Collect()
    {
        UnityEngine.Debug.Log("You picked up a Disc.");
        OnDiscCollected?.Invoke(discData);
    }
}
