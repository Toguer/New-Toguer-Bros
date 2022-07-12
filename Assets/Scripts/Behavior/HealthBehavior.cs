using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract  class HealthBehavior : MonoBehaviour, IKilleable
{
    [SerializeField]protected int hp;
    [SerializeField]private bool invulnerable = false;
    

    
    public virtual void Invulneralbe(int invu)
    {
        if (invu == 1)
        {
            invulnerable = true;
        }
        else
        {
            invulnerable = false;
        }
        
    }
    

    public virtual void Die()
    {
        if(TryGetComponent<DropBehavior>(out DropBehavior Drop))
        {
            Drop.Drop();
        }
        
        Destroy(gameObject, 0.1f);
        
    }

    protected Animator animator;

    virtual public void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public virtual void GetHit(int hit)
    {

        if (!invulnerable)
        {
            hp = hp - hit;
            invulnerable = true;


            if (hp <= 0)
            {
                hp = 0;
                Invoke("Die", 0.2f);
            }
            else
            {
               
                animator.SetTrigger("hit");
            }
        }
        
    }
}
