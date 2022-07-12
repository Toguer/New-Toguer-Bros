using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endLevel : MonoBehaviour
{
    Animator animator;
    [SerializeField]GameObject player;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("FlagFalled"))
        {
            player.GetComponent<PJController>().CanControl=false;
            player.GetComponent<MoveBehaviour>().moveHorizontal(0.7f);
            player.GetComponent<Animator>().SetInteger("walking", 1);

        }
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Bandera toca algo");
        if (other.tag == "Player")
        {
            Debug.Log(other.tag);
            animator.SetTrigger("Fall");
            CamaraFollow.follow = false;

        }
    }
}
