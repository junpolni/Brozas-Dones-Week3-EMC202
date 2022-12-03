using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputItem : MonoBehaviour
{
    public string itemName;
    public TMP_InputField inputField;
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
        itemName = inputField.GetComponent<TMP_InputField>().text;
        
        if (itemName.Equals("diamond sword", StringComparison.InvariantCultureIgnoreCase))
        {
            textDisplay.text = $"Successfully added {itemName}";
            Debug.Log($"Successfully added {itemName}");

            diamondSword.Collect();    
        }
        else if (itemName.Equals("diamond pickaxe", StringComparison.InvariantCultureIgnoreCase))
        {
            textDisplay.text = $"Successfully added {itemName}";
            Debug.Log($"Successfully added {itemName}");

            diamondPickaxe.Collect();

        }
        else if (itemName.Equals("crossbow", StringComparison.InvariantCultureIgnoreCase))
        {
            textDisplay.text = $"Successfully added {itemName}";
            Debug.Log($"Successfully added {itemName}");

            crossbow.Collect();

        }
        else if (itemName.Equals("leather armor", StringComparison.InvariantCultureIgnoreCase))
        {
            textDisplay.text = $"Successfully added {itemName}";
            Debug.Log($"Successfully added {itemName}");

            leatherArmor.Collect();

        }
        else if (itemName.Equals("gold boots", StringComparison.InvariantCultureIgnoreCase))
        {
            textDisplay.text = $"Successfully added {itemName}";
            Debug.Log($"Successfully added {itemName}");

            goldBoots.Collect();

        }
        else if (itemName.Equals("chicken", StringComparison.InvariantCultureIgnoreCase))
        {
            textDisplay.text = $"Successfully added {itemName}";
            Debug.Log($"Successfully added {itemName}");

            chickenHPRegen.Collect();

        }
        else if (itemName.Equals("cookie", StringComparison.InvariantCultureIgnoreCase))
        {
            textDisplay.text = $"Successfully added {itemName}";
            Debug.Log($"Successfully added {itemName}");

            cookieRESIncrease.Collect();

        }
        else if (itemName.Equals("red potion", StringComparison.InvariantCultureIgnoreCase))
        {
            textDisplay.text = $"Successfully added {itemName}";
            Debug.Log($"Successfully added {itemName}");

            redPotionATKBuff.Collect();

        }
        else if (itemName.Equals("watermelon", StringComparison.InvariantCultureIgnoreCase))
        {
            textDisplay.text = $"Successfully added {itemName}";
            Debug.Log($"Successfully added {itemName}");

            watermelonHPRegen.Collect();

        }
        else if (itemName.Equals("gray potion", StringComparison.InvariantCultureIgnoreCase))
        {
            textDisplay.text = $"Successfully added {itemName}";
            Debug.Log($"Successfully added {itemName}");

            grayPotionCRBuff.Collect();

        }
        else if (itemName.Equals("brown book", StringComparison.InvariantCultureIgnoreCase))
        {
            textDisplay.text = $"Successfully added {itemName}";
            Debug.Log($"Successfully added {itemName}");

            brownBook.Collect();
        }
        else if (itemName.Equals("painting", StringComparison.InvariantCultureIgnoreCase))
        {
            textDisplay.text = $"Successfully added {itemName}";
            Debug.Log($"Successfully added {itemName}");

            painting.Collect();
        }
        else if (itemName.Equals("sign", StringComparison.InvariantCultureIgnoreCase))
        {
            textDisplay.text = $"Successfully added {itemName}";
            Debug.Log($"Successfully added {itemName}");

            sign.Collect();
        }
        else if (itemName.Equals("disc", StringComparison.InvariantCultureIgnoreCase))
        {
            textDisplay.text = $"Successfully added {itemName}";
            Debug.Log($"Successfully added {itemName}");

            disc.Collect();
        }
        else if (itemName.Equals("flower pot", StringComparison.InvariantCultureIgnoreCase))
        {
            textDisplay.text = $"Successfully added {itemName}";
            Debug.Log($"Successfully added {itemName}");

            flowerPot.Collect();
        }
        else
        {
            textDisplay.text = $"{itemName} is not available";
            Debug.Log("Invalid item.");

        }

    }

}
