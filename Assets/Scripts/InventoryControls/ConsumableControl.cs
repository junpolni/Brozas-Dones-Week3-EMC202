using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumableControl : MonoBehaviour
{

    [SerializeField] private Chicken_HPRegen chickenHPRegen;
    [SerializeField] private Cookie_RESIncrease cookieRESIncrease;
    [SerializeField] private RedPotion_ATKBuff redPotionATKBuff;
    [SerializeField] private Watermelon_HPRegen watermelonHPRegen;
    [SerializeField] private GrayPotion_CRBuff grayPotionCRBuff;

    public void AddChicken()
    {
        //Chicken_HPRegen newChicken = Instantiate(chickenHPRegen);
        chickenHPRegen.Collect();
    }

    public void AddCookie()
    {
        //Cookie_RESIncrease newCookie = Instantiate(cookieRESIncrease);
        cookieRESIncrease.Collect();
    }

    public void AddRedPotion()
    {
        //RedPotion_ATKBuff newRedPotion = Instantiate(redPotionATKBuff);
        redPotionATKBuff.Collect();
    }

    public void AddWatermelon()
    {
        //Watermelon_HPRegen newWatermelon = Instantiate(watermelonHPRegen);
        watermelonHPRegen.Collect();
    }

    public void AddGrayPotion()
    {
        //GrayPotion_CRBuff newGrayPotion = Instantiate(grayPotionCRBuff);
        grayPotionCRBuff.Collect();
    }
}
