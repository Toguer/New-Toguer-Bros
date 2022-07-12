using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goombaDrop : DropBehavior
{

    public override void Drop()
    {
        if (Random.value >= 0.5f)
        {
            Drop1();
        }
    }
}
