using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceShoot : PjShooter
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.TryGetComponent<MoveBehaviour>(out MoveBehaviour moveBehaviour))
        {
            if (other.TryGetComponent<GoombaHealth>(out GoombaHealth goombaHealth)) { 

                other.GetComponent<GoombaMovement>().enabled = false;
            }
            else
            {
                other.GetComponent<FliyingGoombaMovement>().enabled = false;
            }
        }
        
    }

    
}
