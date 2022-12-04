using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class QuestionDialogue : MonoBehaviour
{
    public event Action OnYesEvent;
    public event Action OnNoEvent;

    public void OnYesButtonClick()
    {
        if (OnYesEvent != null)
        OnYesEvent();
    }

    public void OnNoButtonClick()
    {
        if(OnNoEvent != null)
        OnNoEvent();
    }
}
