using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClickButton : MonoBehaviour {

   
    public Text goldText;
    public DataController dataController;
    public void OnClickAdd()
    {
        int goldPerClick = dataController.GetGoldPerClick();
        dataController.AddGold(goldPerClick);
    }
    public void OnClickSub()
    {
        int goldPerClick = dataController.GetGoldPerClick();
        dataController.SubGold(goldPerClick);
    }

    public void AddGoldPerClick()
    {
        dataController.AddGoldPerClick(1);
    }

    public void SubGoldPerClick()
    {
        dataController.SubGoldPerClick(1);
    }

}
