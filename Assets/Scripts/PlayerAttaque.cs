using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttaque : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private float meleeSpeed;
    [SerializeField] private float damage;
    float timeBtwAttack;
    private void Update()
    {
        if(timeBtwAttack <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                anim.SetTrigger("Attack");
                timeBtwAttack = meleeSpeed;
            }
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ENEMY"))
        {
            //collision.GetComponent<Enemy>().TakeDamage(damage);
            Debug.Log("Enemy Hit");
        }
    }
}
