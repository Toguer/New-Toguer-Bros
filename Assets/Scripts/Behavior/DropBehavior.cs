using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DropBehavior : MonoBehaviour
{
    [SerializeField]protected GameObject drop;

    public abstract void Drop(); 

    protected void Drop1()
    {
        Instantiate(drop, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }

    



}
   

