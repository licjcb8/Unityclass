using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour {

    public Text ItemDisplayer;

    public string itemName;

    public int level;

    public int currentCost;

    public int startCurrentCost = 1;

    public int goldPerSec;
    public int startGoldPerSec = 1;
    public float costPow = 3.14f;
    public float upgradePow = 1.07f;
    public bool isPurchased = false;

	// Use this for initialization
	void Start () {
        DataController.GetInstnace().LoadItemButton(this);
        StartCoroutine("AddGoldLoop");
        UpdateUI();
	}
	public void PurchaseItem()
    {
        if (DataController.GetInstnace().GetGold() >= currentCost)
        {
            isPurchased = true;
            DataController.GetInstnace().SubGold(currentCost);
            level++;
            UpdateItem();
            UpdateUI();
            DataController.GetInstnace().SaveItemButton(this);
        }
    }
    IEnumerator AddGoldLoop()
    {
        while (true)
        {
            if (isPurchased)
            {
                DataController.GetInstnace().AddGold(goldPerSec);
            }
            yield return new WaitForSeconds(1.0f);
        }
    }

    public void UpdateItem()
    {
        goldPerSec = goldPerSec + startGoldPerSec * (int)Mathf.Pow(upgradePow, level);
        currentCost = startCurrentCost * (int)Mathf.Pow(costPow, level);
    }

    public void UpdateUI()
    {
        ItemDisplayer.text = itemName + "\nLevel :" + level + "\nCost :" + currentCost + "\nGoldPerSec :" + goldPerSec + "\nIsPurchased :" + isPurchased;
    }

	// Update is called once per frame
	void Update () {
		
	}
}
