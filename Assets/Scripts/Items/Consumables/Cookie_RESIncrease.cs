using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie_RESIncrease : MonoBehaviour, ICollectible
{
    public static event HandleCookieCollected OnCookieCollected;
    public delegate void HandleCookieCollected(ItemData itemData);
    public ItemData cookieData;

    public void Collect()
    {
        UnityEngine.Debug.Log("You picked up a Cookie.");
        OnCookieCollected?.Invoke(cookieData);
    }
}
