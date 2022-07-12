using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GoldCoin : Drops
{
    public int CoinValue=10;
    public static int CoinsTaked;
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PJController>(out PJController pjController))
        {
            OnTakeCoin.Invoke(CoinValue);
            CoinsTaked++;
            Destroy(this.gameObject);
            
        }
    }
    private void OnEnable()
    {
        PJController.OnKPress += moreDrop;
    }
    protected override void moreDrop()
    {
        CoinValue = CoinValue + 2 * CoinsTaked;
        Debug.Log("New Coin Value: " + CoinValue);
    }

    public static event Action<int> OnTakeCoin = delegate { };
}
