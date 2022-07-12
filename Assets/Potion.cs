using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Potion : Drops
{
    public int heal;


    private void Start()
    {
        heal = UnityEngine.Random.Range(5, 10);
        Debug.Log("Potion: "+ heal);
    }
    protected override void moreDrop()
    {
        heal = heal + 5;
        Debug.Log("Heal +5 =" +heal);
    }

    private void OnEnable()
    {
        PJController.OnYPress += moreDrop;
    }
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PJController>(out PJController pjController))
        {
            OnTakePotion.Invoke(heal);
            Destroy(this.gameObject);
        }
    }
    public static event Action <int>OnTakePotion = delegate { };
}


