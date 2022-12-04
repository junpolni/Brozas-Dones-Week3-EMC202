using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DoubleClickDebug : MonoBehaviour
{
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

	void Update()
	{
		DoubleClicking();
	}

	public void DoubleClicking()
	{
		if (Input.GetMouseButtonDown(0))
		{
			float timeSinceLastClick = Time.time - lastClickTime;

			if (timeSinceLastClick <= DOUBLE_CLICK_TIME)
			{
				DoubleClickEquip();
			}

			lastClickTime = Time.time;

		}

	}

	private void DoubleClickEquip() 
	{

		if (diamondSword)
		{
			itemName.text = (diamondSword.diamondSwordData.displayName);
			itemDescription.text = (diamondSword.diamondSwordData.itemDescription);

			Debug.Log("Item Double Click Test");
		
		}
		else if (crossbow)
		{
			itemName.text = (crossbow.crossbowData.displayName);
			itemDescription.text = (crossbow.crossbowData.itemDescription);

		
		} 
		else if (diamondPickaxe)
		{
			itemName.text = (diamondPickaxe.pickaxeData.displayName);
			itemDescription.text = (diamondPickaxe.pickaxeData.itemDescription);
		
		}
		else if (leatherArmor)
		{
			itemName.text = (leatherArmor.leatherArmorData.displayName);
			itemDescription.text = (leatherArmor.leatherArmorData.itemDescription);
		
		}
		else if (goldBoots)
		{
			itemName.text = (goldBoots.goldBootsData.displayName);
			itemDescription.text = (goldBoots.goldBootsData.itemDescription);
		
		}

		Debug.Log("Double clicked on an equipment");
		
	}

	private void DoubleClickCons() 
	{
		Debug.Log("Double clicked on a consumable item");
	}

	private void DoubleClickMisc()
	{
		Debug.Log("Double clicked on a misc item");
	}

}
