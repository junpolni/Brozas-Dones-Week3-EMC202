using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentControl : MonoBehaviour
{

    [SerializeField] private DiamondSword diamondSword;
    [SerializeField] private Crossbow crossbow;
    [SerializeField] private DiamondPickaxe diamondPickaxe;
    [SerializeField] private LeatherArmor leatherArmor;
    [SerializeField] private GoldBoots goldBoots;

    void Start()
    {
        Debug.Log("Inventory");
    }

    public void AddDiamondSword()
    {
        //DiamondSword newDiamondSword = Instantiate(diamondSword);
        diamondSword.Collect();
    }

    public void AddDiamondPickaxe()
    {
        //DiamondPickaxe newDiamondPickaxe = Instantiate(diamondPickaxe);
        diamondPickaxe.Collect();
    }

    public void AddCrossbow()
    {
        //Crossbow newCrossbow = Instantiate(crossbow);
        crossbow.Collect();
    }

    public void AddLeatherArmor()
    {
        //LeatherArmor newLeatherArmor = Instantiate(leatherArmor);
        leatherArmor.Collect();
    }

    public void AddGoldBoots()
    {
        //GoldBoots newGoldBoots = Instantiate(goldBoots);
        goldBoots.Collect();
    }


}
