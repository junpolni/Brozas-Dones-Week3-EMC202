using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryControl : MonoBehaviour
{
    private Inventory inventory;
    
    [SerializeField] private DiamondSword diamondSword;
    [SerializeField] private Chicken_HPRegen chickenHPRegen;
    [SerializeField] private BrownBook brownBook;

    void Start()
    {
        inventory = new Inventory();

        Debug.Log("Inventory");
    }

    public void AddEquipment()
    {
        DiamondSword newDiamondSword = Instantiate(diamondSword);
        newDiamondSword.Collect();
        //Debug.Log("Equipment added.");
    }

    public void AddConsumable()
    {
        Chicken_HPRegen newChicken = Instantiate(chickenHPRegen);
        newChicken.Collect();
        //Debug.Log("Consumable added.");

    }

    public void AddMisc()
    {
        BrownBook newBrownBook = Instantiate(brownBook);
        newBrownBook.Collect();
        //Debug.Log("Misc added.");
    }
}