using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PJController : MortalMovement
{
    [SerializeField]  private LayerMask platfromLayerMask;
    
    bool facingRight = true;
    bool childofPlatform;
    BoxCollider2D boxCollider2D;
    float verticalLastPosition;
    public static bool touchingGround;
    [SerializeField] private PjShooter shoot;
    bool canControl = true;

    public bool CanControl { get => canControl; set => canControl = value; }

    void Start()
    {
        
        boxCollider2D = GetComponent<BoxCollider2D>();
       
    }
    public static event Action OnYPress = delegate { };
    public static event Action OnUPress = delegate { };
    public static event Action OnKPress = delegate { };
    // Update is called once per frame
    void Update()
    {
        if (canControl)
        {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                OnYPress.Invoke();
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                OnUPress.Invoke();
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                OnKPress.Invoke();
            }

        
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                shoot.Shot();
            }
        
            if (!touchingGround)
            {
                if (verticalLastPosition > transform.position.y)
                {
                    animator.SetInteger("Jumping", 2);
                }verticalLastPosition = transform.position.y;
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    float jumpspeed = 5;
                    movebehavior.Jump(jumpspeed);
                    animator.SetInteger("Jumping", 1);
                }
                else
                {
                    animator.SetInteger("Jumping", 0);
                }

            }
       
            if (Input.GetKey(KeyCode.D ))
            {
                float moveForce=1.5f;
            
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    moveForce = 2.5f;
                    animator.SetInteger("walking", 2);
                }
                else
                {
                    animator.SetInteger("walking", 1);
                }
                movebehavior.moveHorizontal(moveForce);
                if (facingRight == false)
                {
                    flipSprite.Flip();
                    facingRight = true;
                }
            }
            else if (Input.GetKey(KeyCode.A))
            {
                float moveForce = 1.5f;
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    moveForce = 2.5f;
                    animator.SetInteger("walking", 2);
                }
                else
                {
                
                    animator.SetInteger("walking", 1);
                }
                movebehavior.moveHorizontal(-moveForce);
                if (facingRight == true)
                {
                   flipSprite.Flip();
                    facingRight = false;
                }
            }
            else
            {
                animator.SetInteger("walking", 0);
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MovingPlatform")
        {
            childofPlatform = true;
            this.gameObject.transform.parent = collision.gameObject.transform;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        childofPlatform = false;
        this.gameObject.transform.parent = null;
    }

    

}
