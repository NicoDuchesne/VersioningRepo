using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject bloofSplash;
    private CircleCollider2D colliderPlayer;
    private Rigidbody2D rb;


    void Awake()
    {
        colliderPlayer = GetComponent<CircleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
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
        rb.velocity = Vector2.zero;
        rb.bodyType = RigidbodyType2D.Static;
        //anim.SetTrigger("Death"); d�clencehr l'animation de mort une fois
    }
}
