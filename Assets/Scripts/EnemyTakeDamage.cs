using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyTakeDamage : MonoBehaviour
{
    [SerializeField] private int health;
    private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite spriteDeath;
    private CircleCollider2D colliderEnemy;
    private Rigidbody2D rb;
    [SerializeField] private float forceKnockback;
    [SerializeField] private float forceKnockbackTime;
    [SerializeField] private Transform playerTop;
    private float distanceX;
    private float distanceY;
    [SerializeField] private GameObject bloofSplash;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        colliderEnemy = GetComponent<CircleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            spriteRenderer.sprite = spriteDeath;

            colliderEnemy.enabled = false;
            Instantiate(bloofSplash, transform.position, Quaternion.identity);
        }
        distanceX = playerTop.position.x - transform.position.x;
        distanceY = playerTop.position.y - transform.position.y;
        rb.AddForce(new Vector2(-distanceX * forceKnockback, -distanceY * forceKnockback), ForceMode2D.Impulse);
        StartCoroutine(KnockbackTime(rb));
    }

    private IEnumerator KnockbackTime(Rigidbody2D enemyRb)
    {
        yield return new WaitForSeconds(forceKnockbackTime);
        enemyRb.velocity = Vector2.zero;
        if (health <= 0)
        {
            rb.bodyType = RigidbodyType2D.Kinematic;
        }
    }
}
