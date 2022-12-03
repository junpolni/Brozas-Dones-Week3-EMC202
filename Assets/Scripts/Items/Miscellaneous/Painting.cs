using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour, ICollectible
{
    public static event HandlePaintingCollected OnPaintingCollected;
    public delegate void HandlePaintingCollected(ItemData itemData);
    public ItemData paintingData;

    public void Collect()
    {
        UnityEngine.Debug.Log("You picked up a Painting.");
        OnPaintingCollected?.Invoke(paintingData);
    }
}
