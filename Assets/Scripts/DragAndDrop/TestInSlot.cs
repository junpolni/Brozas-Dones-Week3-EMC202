using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestInSlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Transform parentAfterSwap;
        GameObject dropped = eventData.pointerDrag;
        DragDrop draggableItem = dropped.GetComponent<DragDrop>();
        if (transform.childCount== 0)
        {
            draggableItem.parentAfterDrag = transform;
        }
        else
        {
            parentAfterSwap = draggableItem.parentAfterDrag;
            transform.GetChild(0).SetParent(parentAfterSwap);
            draggableItem.parentAfterDrag = transform;
        }
    }
}