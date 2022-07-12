using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AttackBehavior : MonoBehaviour
{
    
    protected int hit = 1;

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent<HealthBehavior>(out HealthBehavior otherHealth)) 
        {
            otherHealth.GetHit(hit);
            //other.gameObject<Goomba>()
         //   other.gameObject.GetComponent<Health>().);
            
        }
    }

}
