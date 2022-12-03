using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken_HPRegen : MonoBehaviour, ICollectible
{
    public static event HandleChickenCollected OnChickenCollected;
    public delegate void HandleChickenCollected(ItemData itemData);
    public ItemData chickenData;

    public void Collect()
    {
        UnityEngine.Debug.Log("You picked up a Chicken.");
        OnChickenCollected?.Invoke(chickenData);
    }
}
