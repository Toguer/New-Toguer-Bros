using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : PlatformBehavior
{
    public List<Transform> WayPoints;
    public float velocity;
    private float t=0;
    bool goBack=false;
    void Update()
    {
        t = t + velocity;
        if (t <= 1 && !goBack)
        {
            transform.position = Vector3.Lerp(WayPoints[0].position, WayPoints[1].position, t);
        }else if (t >= 1 && !goBack)
        {
            goBack = true;
            t = 0;
        }else if (goBack && t<=1)
        {
            transform.position = Vector3.Lerp(WayPoints[1].position, WayPoints[0].position, t);
        }else if (goBack && t>=1)
        {
            goBack = false;
            t = 0;
        }
        
        
       
    }

    private void OnDrawGizmos()
    {
        Debug.DrawLine(WayPoints[0].position, WayPoints[1].position);
    }
}
