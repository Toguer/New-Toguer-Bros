using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlatformBehavior : MonoBehaviour
{
    protected EdgeCollider2D eC2d;

    protected virtual void Awake()
    {
        eC2d = GetComponent<EdgeCollider2D>();
    }
}
