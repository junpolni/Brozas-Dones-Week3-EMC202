using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPotion_ATKBuff : MonoBehaviour, ICollectible
{
    public static event HandleRedPotionCollected OnRedPotionCollected;
    public delegate void HandleRedPotionCollected(ItemData itemData);
    public ItemData redPotionData;

    public void Collect()
    {
        UnityEngine.Debug.Log("You picked up a Red Potion.");
        OnRedPotionCollected?.Invoke(redPotionData);
    }
}
