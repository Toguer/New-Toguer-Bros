using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaHealth : HealthBehavior
{
    public override void Die()
    {
        transform.localScale=new Vector3(1,0.5f,1);
        
        base.Die();
    }

}
