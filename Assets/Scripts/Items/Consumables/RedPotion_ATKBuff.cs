using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RedPotion_ATKBuff : MonoBehaviour, ICollectible
{
    public static event HandleRedPotionCollected OnRedPotionCollected;
    public delegate void HandleRedPotionCollected(ItemData itemData);

    public static event HandleRedPotionConsumed OnRedPotionConsumed;
    public delegate void HandleRedPotionConsumed(ItemData itemData);

    public ItemData redPotionData;

    public void Collect()
    {
        UnityEngine.Debug.Log("You picked up a Red Potion.");
        OnRedPotionCollected?.Invoke(redPotionData);
    }

    public void Consume()
    {
        UnityEngine.Debug.Log("You consumed a Red Potion.");
        OnRedPotionConsumed?.Invoke(redPotionData);
    }
}
