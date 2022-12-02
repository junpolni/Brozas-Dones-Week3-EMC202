using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownBook : MonoBehaviour
{
    public static event HandleBrownBookCollected OnBrownBookCollected;
    public delegate void HandleBrownBookCollected(ItemData itemData);
    public ItemData brownBookData;

    public void Collect()
    {
        UnityEngine.Debug.Log("You picked up a Brown Book.");
        OnBrownBookCollected?.Invoke(brownBookData);
    }
}
