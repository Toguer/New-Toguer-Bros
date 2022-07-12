using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mortal : MonoBehaviour
{
    protected BoxCollider2D bC2d;
    protected BoxCollider2D ChildCollider;

    protected virtual void Awake()
    {
        bC2d = GetComponent<BoxCollider2D>();
        ChildCollider = GetComponentInChildren<BoxCollider2D>();
    }

    // Update is called once per frame
    
}
