using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemDragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler
{
    public Image image;

    [HideInInspector] public Transform parentAfterDrag;

    void Start()
    {
        image = GetComponent<Image>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.parent.parent);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        transform.position = Input.mousePosition;
        
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        transform.localPosition = Vector3.zero;
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
    }

    private int clicks = 0;
    public void OnPointerDown(PointerEventData eventData)
    {
        clicks++;
        if (clicks >= 2)
        {
            clicks = 0;
            
            var obj = eventData.pointerEnter;
            Debug.Log(obj.name);
            
            var parent = obj.GetComponentInParent<InventorySlot>();

            var itemName = string.Empty;
            var itemDesc = string.Empty;

            switch (parent.Item.itemData.Type)
            {
                case ItemType.Consumables:
                    //you can do something consume heree
                case ItemType.Equipment:
                     itemName = parent.Item.itemData.displayName;
                     itemDesc = parent.Item.itemData.itemDescription;
                    break;
                case ItemType.Miscellaneous:
                    break;
            }

            DoubleClickDebug.Instance.Display(itemName, itemDesc);
            
            // ICollectible interactable = obj.GetComponent<ICollectible>();
            // interactable.Interact();
        }
    }
}
