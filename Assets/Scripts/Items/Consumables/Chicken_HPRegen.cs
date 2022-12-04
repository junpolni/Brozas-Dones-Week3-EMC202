using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Chicken_HPRegen : MonoBehaviour, ICollectible
{
    public static event HandleChickenCollected OnChickenCollected;
    public delegate void HandleChickenCollected(ItemData itemData);

    public static event HandleChickenConsumed OnChickenConsumed;
    public delegate void HandleChickenConsumed(ItemData itemData);

    public ItemData chickenData;

    public void Collect()
    {
        UnityEngine.Debug.Log("You picked up a Chicken.");
        OnChickenCollected?.Invoke(chickenData);
    }

    public void Consume()
    {
        UnityEngine.Debug.Log("You consumed a Chicken.");
        OnChickenConsumed?.Invoke(chickenData);
    }
}
