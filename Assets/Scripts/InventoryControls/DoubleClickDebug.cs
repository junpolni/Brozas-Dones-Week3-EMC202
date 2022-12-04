using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DoubleClickDebug : MonoBehaviour
{
	public static DoubleClickDebug Instance;
	
	private const float DOUBLE_CLICK_TIME = .2f;

	private float lastClickTime;

	public TextMeshProUGUI itemName;
	public TextMeshProUGUI itemDescription;

	private ItemData itemData;
	
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

    private void Awake()
    {
	    Instance = this;
    }

    public void Display(string name, string description)
    {
	    itemName.text = name;
	    itemDescription.text = description;
    }

    void Update()
	{
		//DoubleClicking();
	}

	public void DoubleClicking()
	{
		if (Input.GetMouseButtonDown(0))
		{
			float timeSinceLastClick = Time.time - lastClickTime;

			if (timeSinceLastClick <= DOUBLE_CLICK_TIME)
			{
				
				Debug.Log("Double Clicked Item");
			}

			lastClickTime = Time.time;

		}

	}

	// itemName.text = (chickenHPRegen.chickenData.displayName);
	// itemDescription.text = (chickenHPRegen.chickenData.itemDescription);
	//
	// Debug.Log("Double clicked on a consumable");
	//
	// chickenHPRegen.Consume();
	
}
