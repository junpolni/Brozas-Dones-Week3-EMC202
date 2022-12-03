using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public TextMeshProUGUI stackText;

    public void ClearSlot()
    {
        icon.enabled = false;
        stackText.enabled = false;
    }

    public void DrawSlot(InventoryItem item)
    {
        if(item == null)
        {
            ClearSlot();
            return;
        }

        icon.enabled = true;
        stackText.enabled = true;

        icon.sprite = item.itemData.icon;

        if (item.stackSize > 1)
        {
            stackText.text = item.stackSize.ToString();
        } 
        else
        {
            stackText.text = "";
        }
        
    }
}
