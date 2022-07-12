using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FliyingGoombaHealth : HealthBehavior
{
    public GameObject goomba;
    protected int health=1;
    public override void Die()
    {
        
        MoveBehaviour move = GetComponent<MoveBehaviour>();
        GetComponent<FliyingGoombaMovement>().enabled = false;
        StartCoroutine(Fall(move));
        // Instantiate(goomba, new Vector3(transform.position.x, transform.position.y-0.25f, transform.position.z), Quaternion.identity);
        //base.Die();
        
    }

    public IEnumerator Fall(MoveBehaviour move)
    {
        float timer = 0.20f;
        while (timer > 0 ) {
            move.Jump(-1f);
            timer = timer - Time.deltaTime;
            yield return new WaitForFixedUpdate();
        }
         Instantiate(goomba, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        base.Die();
    }

    public override void GetHit(int hit)
    {
        hp = hp - hit;
        if (hp <= 0)
        {
            hp = 0;
            Invoke("Die", 0.2f);
        }
    }
    /*  public void InstantGoomba()
      {
          Debug.Log("Instantiate Done");
          Instantiate(goomba, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
      }*/


}
