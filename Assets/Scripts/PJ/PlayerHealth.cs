using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : HealthBehavior
{
    float lowerscale=0.7f;
    public virtual void goLittle()
    {
        transform.localScale=new Vector3(lowerscale, lowerscale, lowerscale);   
    }

    private void OnEnable()
    {
        Potion.OnTakePotion += AddLife;
    }

    public void AddLife(int hpsum)
    {
        this.hp = hp+hpsum;
        if (hp > 100)
        {
            hp = 100;
        }
    }
}
