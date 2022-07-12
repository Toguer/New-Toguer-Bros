using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageDrop : DropBehavior
{
    public override void Drop()
    {
        Drop1(); //potion drop
    }
 /*   protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if(TryGetComponent<PJController>(out PJController pjController))
        {
            EventController.current.PotionTake();
        }
        
    }*/
}
