using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipSprite : MonoBehaviour
{
    
    public void Flip()
    {
        transform.Rotate(new Vector3(0, -180, 0));
    }
    
}
