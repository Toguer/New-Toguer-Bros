using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventController : MonoBehaviour
{
    public static EventController current;


    private void Awake()
    {
        current = this;
    }

    public event Action onGoldTake;
    public event Action onPotionTake;
    public void CoinTake()
    {
        onGoldTake();
    }
    public void PotionTake()
    {
        onPotionTake();
    }
}
