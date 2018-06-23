using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpgradeButton : MonoBehaviour {
    public Text UpgradeText;
    public string upgradeName;

    public int goldByupgrade;
    public int startGoldByupgrade = 1;

    public int currentCost = 1;
    public int startCurrentCost;

    public int level = 1;

    public float upgradePow = 1.07f;
    public float costPow = 3.14f;

    // Use this for initialization
    void Start() {
        currentCost = startCurrentCost;
        level = 1;
        goldByupgrade = startGoldByupgrade;
        UpdateUI();
    }

    // Update is called once per frame
    void Update() {

    }
    public void PurcahseUpgrade()
    {
        if (DataController.GetInstnace().GetGold() <= currentCost)
        {
            DataController.GetInstnace().SubGold(currentCost);
            level++;
            DataController.GetInstnace().AddGoldPerClick(goldByupgrade);
            UpdateUpgrade();
            UpdateUI();
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
