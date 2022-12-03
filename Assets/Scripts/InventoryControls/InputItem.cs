using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputItem : MonoBehaviour
{
    public static event Action<List<ItemData>> OnItemAddedToInventory;
    public List<ItemData> itemData = new List<ItemData>();

    public string itemName;
    public TextMeshProUGUI inputField;
    public TextMeshProUGUI textDisplay;

    // Equipment Items
    [SerializeField] private DiamondSword diamondSword;
    [SerializeField] private Crossbow crossbow;
    [SerializeField] private DiamondPickaxe diamondPickaxe;
    [SerializeField] private LeatherArmor leatherArmor;
    [SerializeField] private GoldBoots goldBoots;

    // Consumable Items
    [SerializeField] private Chicken_HPRegen chickenHPRegen;
    [SerializeField] private Cookie_RESIncrease cookieRESIncrease;
    [SerializeField] private RedPotion_ATKBuff redPotionATKBuff;
    [SerializeField] private Watermelon_HPRegen watermelonHPRegen;
    [SerializeField] private GrayPotion_CRBuff grayPotionCRBuff;

    // Misc Items
    [SerializeField] private BrownBook brownBook;
    [SerializeField] private Painting painting;
    [SerializeField] private Sign sign;
    [SerializeField] private Disc disc;
    [SerializeField] private FlowerPot flowerPot;
    

    //, StringComparison.InvariantCultureIgnoreCase)

    public void AddItemName()
    {
        itemName = inputField.text;

        if (itemName.Equals("DiamondSword"))
        {
            //DiamondSword newDiamondSword = Instantiate(diamondSword);
            diamondSword.Collect();

            textDisplay.text = $"Successfully added {itemName}";
            Debug.Log($"Successfully added {itemName}");
            OnItemAddedToInventory?.Invoke(itemData);
        }
        else if (itemName.Equals("Chicken"))
        {
            chickenHPRegen.Collect();

            textDisplay.text = $"Successfully added {itemName}";
            Debug.Log($"Successfully added {itemName}");
            OnItemAddedToInventory?.Invoke(itemData);
        } 
        else if (itemName.Equals("Brown Book"))
        {
            brownBook.Collect();

            textDisplay.text = $"Successfully added {itemName}";
            Debug.Log($"Successfully added {itemName}");
            OnItemAddedToInventory?.Invoke(itemData);
        } 
        else if (itemName.Equals(""))
        {
            textDisplay.text = "Enter a valid item";
            Debug.Log("Enter a valid item");
        }
        else
        {
            textDisplay.text = $"{inputField.text} is an invalid Item.";
            Debug.Log($"{inputField.text} is an invalid Item.");
        }     
    }


}
