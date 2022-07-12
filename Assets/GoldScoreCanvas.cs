using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GoldScoreCanvas : MonoBehaviour
{
    int goldCoins = 0;
    private Text textCoin;

    private void Start()
    {
        textCoin = GetComponent<Text>();
        GoldCoin.OnTakeCoin += addCoins;
    }

    public void addCoins(int CoinValue)
    {
        goldCoins=goldCoins+CoinValue;
        textCoin.text = "Coins: " + goldCoins.ToString();
    }
}