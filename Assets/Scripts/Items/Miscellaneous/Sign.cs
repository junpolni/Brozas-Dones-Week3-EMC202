using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour, ICollectible
{
    public static event HandleSignCollected OnSignCollected;
    public delegate void HandleSignCollected(ItemData itemData);
    public ItemData signData;

    public void Collect()
    {
        UnityEngine.Debug.Log("You picked up a Sign.");
        OnSignCollected?.Invoke(signData);
    }
}
