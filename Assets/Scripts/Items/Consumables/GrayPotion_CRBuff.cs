using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GrayPotion_CRBuff : MonoBehaviour, ICollectible
{
    public static event HandleGrayPotionCollected OnGrayPotionCollected;
    public delegate void HandleGrayPotionCollected (ItemData itemData);

    public static event HandleGrayPotionConsumed OnGrayPotionConsumed;
    public delegate void HandleGrayPotionConsumed(ItemData itemData);

    public ItemData grayPotionData;

    public void Collect()
    {
        UnityEngine.Debug.Log("You picked up a Gray Potion.");
        OnGrayPotionCollected?.Invoke(grayPotionData);
    }

    public void Consume()
    {
        UnityEngine.Debug.Log("You consumed a Gray Potion.");
        OnGrayPotionConsumed?.Invoke(grayPotionData);
    }
    
}
