using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FliyingGoombaMovement : MortalMovement
{
    public List<Transform> path;
    float distance;
    int nextpoint=0;
    Vector3 dir;

    private void Start()
    {
        dir = path[0].position - transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        distance=Vector3.Distance(path[nextpoint].position, transform.position);
        if (distance < 0.2f)
        {
            if (nextpoint == 0)
            {
                nextpoint = 1;
            }
            else
            {
                nextpoint = 0;
            }
        }
        dir= path[nextpoint].position - transform.position;
        movebehavior.move(dir);
    }
}
