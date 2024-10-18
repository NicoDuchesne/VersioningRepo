using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDealDamage : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private Animator anim;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //anim.SetTrigger("EnemyAttack"); déclencehr l'animation d'attaque de l'ennemi une fois
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
            Debug.Log("an enemy hit the player");
        }
    }
}
