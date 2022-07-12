using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  PjShooter : MonoBehaviour
{
    [SerializeField]protected GameObject ShotPoint;
    [SerializeField]protected GameObject ShotBall;



    // Update is called once per frame
    virtual public void Shot()
    {
            Debug.Log(ShotPoint.transform.rotation.y);
            
            
            if (ShotPoint.transform.parent.transform.rotation.y == 1)
            {
            GameObject f = Instantiate(ShotBall, ShotPoint.transform);
            f.gameObject.transform.parent = null;
            f.GetComponent<MoveBehaviour>().Direction= new Vector2(-1, 0);
            }
            else
            {
            GameObject f = Instantiate(ShotBall, ShotPoint.transform);
            f.gameObject.transform.parent = null;
            f.GetComponent<MoveBehaviour>().Direction = new Vector2(1, 0);
            }
        }
    
}
