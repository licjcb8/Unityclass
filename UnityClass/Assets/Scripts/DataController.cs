﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour {
    private int m_gold = 0;
    private int m_goldPerClick = 0;
    private static DataController instance;

    public static DataController GetInstnace()
    {
        if (instance == null)
        {
            instance = FindObjectOfType<DataController>();
            if(instance ==null)
            {
                GameObject container = new GameObject("DataController");
                    instance = container.AddComponent<DataController>();

            }
        }
        return instance;
    }

    void Awake()
    {
        m_gold = PlayerPrefs.GetInt("Gold");
        m_goldPerClick = PlayerPrefs.GetInt("GoldPerClick", 1);
    }

    public void SetGold(int newGold)
    {
        m_gold = newGold;
        PlayerPrefs.SetInt("Gold", m_gold);
    }

    public void AddGold(int newGold)
    {
        m_gold += newGold;
        SetGold(m_gold);
    }
    public void AddGoldPerClick(int newGoldPerClick)
    {
        m_goldPerClick += newGoldPerClick;
        SetGoldPerClick(m_goldPerClick);
    }
    public void SubGoldPerClick(int newGoldPerClick)
    {
        m_goldPerClick -= newGoldPerClick;
        SetGoldPerClick(m_goldPerClick);
    }
    public void SubGold(int newGold)
    {
        m_gold -= newGold;
        SetGold(m_gold);
    }

    public int GetGold()
    {
        return m_gold;
    }

    public int GetGoldPerClick()
    {
        return m_goldPerClick;
    }

    public void SetGoldPerClick(int newGoldPerClick)
    {
        m_goldPerClick = newGoldPerClick;
        PlayerPrefs.SetInt("GoldPerClick", m_goldPerClick);

    }

    


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
