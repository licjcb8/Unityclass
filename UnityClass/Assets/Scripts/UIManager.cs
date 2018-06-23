using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour {
    public Text goldText;
    public Text GoldPerClickText;

    public DataController dataController;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        goldText.text = "Gold : " + dataController.GetGold();
        GoldPerClickText.text = "GoldPerClick : " + dataController.GetGoldPerClick();

    }
}
