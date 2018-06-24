using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpgradeButton : MonoBehaviour {
    public Text UpgradeText;
    public string upgradeName;

    
    public int goldByupgrade;
    public int startGoldByupgrade;


    public int currentCost;
    public int startCurrentCost;


    public int level = 1;

    public float upgradePow = 1.07f;
    public float costPow = 3.14f;

    // Use this for initialization
    void Start() {
        DataController.GetInstnace().LoadUpgradeButton(this);
        UpdateUI();
    }

    
       public void PurcahseUpgrade()
    {
        if (DataController.GetInstnace().GetGold() >= currentCost)
        {
            DataController.GetInstnace().SubGold(currentCost);
            level++;
            DataController.GetInstnace().AddGoldPerClick(goldByupgrade);
            UpdateUpgrade();
            UpdateUI();
            DataController.GetInstnace().SaveUpgradeButton(this);
        }
    }

    public void UpdateUpgrade()
    {
        goldByupgrade = startGoldByupgrade * (int)Mathf.Pow(upgradePow, level);
        currentCost = startCurrentCost * (int)Mathf.Pow(costPow, level);
    }

    void UpdateUI()
    {
        UpgradeText.text = upgradeName + "\nCost: " + currentCost + "\nLevel: " + level + "\nNext new GoldPerClick: " + goldByupgrade;
    }

}
