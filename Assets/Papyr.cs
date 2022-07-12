using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Papyr : Drops
{
    public int mana;
    void Start()
    {
        mana = UnityEngine.Random.Range(50, 100);
        Debug.Log("Papyr: "+ mana);
    }

    // Update is called once per frame
    private void OnEnable()
    {
        PJController.OnUPress += moreDrop;
    }
    protected override void moreDrop()
    {
        mana = mana + UnityEngine.Random.Range(30, 70);
        Debug.Log("New mana in Papyr: " + mana);
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PJController>(out PJController pjController))
        {
            OnTakePapyr.Invoke(mana);
            Destroy(this.gameObject);
        }
    }

    public static event Action<int> OnTakePapyr = delegate { };
}

