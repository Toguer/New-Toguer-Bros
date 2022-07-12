using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PointDrops : MonoBehaviour
{
    int GoldCoins=0;
    
    private Text textCoin;
/*
    private void Start()
    {
        textCoin = GetComponent<Text>();
        EventController.current.onGoldTake += addCoins;
    }
    */
    public void addCoins()
    {
            GoldCoins++;
            textCoin.text = "Coins: " + GoldCoins.ToString();
    }
}
