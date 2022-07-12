using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMana : MonoBehaviour
{
    public int mana;
    private void OnEnable()
    {
        Papyr.OnTakePapyr += moreMana;
    }

    private void moreMana(int moremana)
    {
        mana = mana + moremana;
        if (mana > 500)
        {
            mana = 500;
        }
    }

}
