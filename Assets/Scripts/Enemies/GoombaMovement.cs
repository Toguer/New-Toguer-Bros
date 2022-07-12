using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaMovement : MortalMovement
{
    [SerializeField]bool facingRight = true;
    private float speed=1f;

    // Update is called once per frame
    void Update()
    {
        if (facingRight)
        {
            movebehavior.moveHorizontal(speed);
        }
        else
        {
            movebehavior.moveHorizontal(-speed);
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.gameObject.layer == 9 || collision.collider.gameObject.layer == 14)
        {
            if (facingRight)
            {

                facingRight = false;
            }
            else
            {
                facingRight = true;
            }
            flipSprite.Flip();
        }
        
    }


}
