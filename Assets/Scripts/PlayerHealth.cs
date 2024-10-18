using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject bloofSplash;
    private CircleCollider2D colliderPlayer;

    

    void Awake()
    {
        colliderPlayer = GetComponent<CircleCollider2D>();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            PlayDeath();
        }
    }

    private void PlayDeath()
    {
        Instantiate(bloofSplash, transform.position, Quaternion.identity);
        Debug.Log("Player est mort");
        gameObject.GetComponent<PlayerControl>().enabled = false;
        gameObject.GetComponent<PlayerRotation>().enabled = false;
        gameObject.GetComponentInChildren<PlayerBottomRotation>().enabled = false;
        gameObject.GetComponentInChildren<PlayerAttaque>().enabled = false;
        //anim.SetTrigger("Death"); déclencehr l'animation de mort une fois
    }
}
