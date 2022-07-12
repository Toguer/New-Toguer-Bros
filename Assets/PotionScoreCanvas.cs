using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PotionScoreCanvas : MonoBehaviour
{
    int PotionScore = 0;

    private Text textPotion;

  /*  private void Start()
    {
        textPotion = GetComponent<Text>();
        Potion.OnTakePotion += addPotions;
    }*/

    public void addPotions()
    {
        PotionScore++;
        textPotion.text = "Potions: " + PotionScore.ToString();
    }
}