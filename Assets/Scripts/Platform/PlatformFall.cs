using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : PlatformBehavior
{
    MoveBehaviour moveBehaviour;
    [SerializeField] float ShakeForce;
    [SerializeField] float fallSpeed;
    [SerializeField] float timetoRespawn;
    Vector3 StartPosition;
    SpriteRenderer spriteRenderer;
    EdgeCollider2D edgeCollider2D;
    protected override void Awake()
    {
        base.Awake();
        moveBehaviour = GetComponent<MoveBehaviour>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        edgeCollider2D = GetComponent<EdgeCollider2D>();
        StartPosition = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("TriggerEnter");
        if(other.gameObject.layer == 12)
        {

            StartCoroutine(PrepareToFall());

            Debug.Log(other.gameObject.layer);
        }
    }

    public IEnumerator PrepareToFall()
    {
        float timer = 1.5f;
        while (timer > 0)
        {
            timer = timer - Time.deltaTime;
            //moveBehaviour.move(new Vector3(transform.position.x+ ShakeForce, transform.position.y,transform.position.z)) ;
            transform.position = new Vector3(transform.position.x + ShakeForce, transform.position.y, transform.position.z);
            yield return new WaitForFixedUpdate();
            transform.position = new Vector3(transform.position.x - ShakeForce, transform.position.y, transform.position.z);
            //moveBehaviour.move(new Vector3(transform.position.x - ShakeForce, transform.position.y, transform.position.z));
            yield return new WaitForFixedUpdate();
        }
        StartCoroutine(Falling());

    }
    public IEnumerator Falling()
    {
        float timer = 0.5f;
        while (timer > 0)
        {
            timer = timer - Time.deltaTime;
            edgeCollider2D.enabled = false;
            transform.position = new Vector3(transform.position.x, transform.position.y - fallSpeed, transform.position.z);
            yield return new WaitForFixedUpdate();
        }
        spriteRenderer.enabled = false;
        
        StartCoroutine(WaitForRespawn());

    }
    public IEnumerator WaitForRespawn()
    {
        yield return new WaitForSeconds(timetoRespawn);
        transform.position = StartPosition;
        spriteRenderer.enabled = true;
        edgeCollider2D.enabled = true;
    }
}
