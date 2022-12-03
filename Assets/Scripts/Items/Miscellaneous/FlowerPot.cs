using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerPot : MonoBehaviour, ICollectible
{
    public static event HandleFlowerPotCollected OnFlowerPotCollected;
    public delegate void HandleFlowerPotCollected(ItemData itemData);
    public ItemData flowerPotData;

    public void Collect()
    {
        UnityEngine.Debug.Log("You picked up a Flower Pot.");
        OnFlowerPotCollected?.Invoke(flowerPotData);
    }
}
