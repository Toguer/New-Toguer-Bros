using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MortalMovement : MonoBehaviour
{
   
    protected MoveBehaviour movebehavior;
    protected FlipSprite flipSprite;
    protected SpriteRenderer spriteRenderer;
    protected Animator animator;

    protected virtual void Awake()
    {
        movebehavior = GetComponent<MoveBehaviour>();
        flipSprite = GetComponent<FlipSprite>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

}
