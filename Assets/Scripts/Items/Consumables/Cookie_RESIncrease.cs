using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cookie_RESIncrease : MonoBehaviour, ICollectible
{
    public static event HandleCookieCollected OnCookieCollected;
    public delegate void HandleCookieCollected(ItemData itemData);

    public static event HandleCookieConsumed OnCookieConsumed;
    public delegate void HandleCookieConsumed(ItemData itemData);

    public ItemData cookieData;

    public void Collect()
    {
        UnityEngine.Debug.Log("You picked up a Cookie.");
        OnCookieCollected?.Invoke(cookieData);
    }

    public void Consume()
    {
        UnityEngine.Debug.Log("You consumed a Cookie.");
        OnCookieConsumed?.Invoke(cookieData);
    }
}
