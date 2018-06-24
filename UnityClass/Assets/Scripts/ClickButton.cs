using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClickButton : MonoBehaviour {

   
    public Text goldText;
    public DataController dataController;
    public GameObject effect1;
    public GameObject effect2;
    public void OnClickAdd()
    {
        int goldPerClick = dataController.GetGoldPerClick();
        dataController.AddGold(goldPerClick);
        Instantiate(effect1, this.transform.position, this.transform.rotation);
        Instantiate(effect2, this.transform.position, this.transform.rotation);
    }

}
