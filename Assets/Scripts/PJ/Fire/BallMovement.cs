using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    MoveBehaviour moveBehavior;
    void Awake()
    {

        moveBehavior = GetComponent<MoveBehaviour>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveBehavior.move();

    }
    
}
