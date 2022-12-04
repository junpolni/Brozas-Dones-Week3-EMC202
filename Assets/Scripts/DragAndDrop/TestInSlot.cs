using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestInSlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 1)
        {
            GameObject dropped = eventData.pointerDrag;
            ItemDragHandler draggableItem = dropped.GetComponent<ItemDragHandler>();
            Transform tempDragItemParent = draggableItem.parentAfterDrag;
            draggableItem.parentAfterDrag = transform;

            Transform currentIconObj = transform.GetChild(0);
            currentIconObj.transform.SetParent(tempDragItemParent.transform, false);
            
        }

        Debug.Log("Test Drop");
        
    }
}