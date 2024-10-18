using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyTakeDamage : MonoBehaviour
{
    [SerializeField] private int health;
    private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite spriteDeath;
    [SerializeField] private Sprite spriteBasic;
    private CircleCollider2D colliderEnemy;
    private Rigidbody2D rb;
    [SerializeField] private float forceKnockback;
    [SerializeField] private float forceKnockbackTime;
    [SerializeField] private Transform playerTop;
    private float distanceX;
    private float distanceY;
    [SerializeField] private GameObject bloofSplash;
    private EnemiesManager enemiesManager;

    private void Awake()
    {
        enemiesManager = GameObject.Find("EnemiesManager").GetComponent<EnemiesManager>();
    }
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        colliderEnemy = GetComponent<CircleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        playerTop = GameObject.Find("haut").transform;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health == 1 && gameObject.name.Substring(0, 11) == "EnemyShield")
        {
            spriteRenderer.sprite = spriteBasic;
        }

        if (health <= 0)
        {
            spriteRenderer.sprite = spriteDeath;

            if (gameObject.name.Substring(0, 13) == "EnemyDistance")
            {
                GetComponent<EnemyShooting>().enabled = false;
            } else
            {
                GetComponent<EnemyDealDamage>().enabled = false;
            }
            GetComponent<NavMeshAgent>().enabled = false;
            GetComponent<EnemyNav>().enabled = false;
            GetComponent<EnemyTakeDamage>().enabled = false;
            gameObject.tag = "dead";

            colliderEnemy.enabled = false;
            Instantiate(bloofSplash, transform.position, Quaternion.identity);
        }
        distanceX = playerTop.position.x - transform.position.x;
        distanceY = playerTop.position.y - transform.position.y;
        rb.AddForce(new Vector2(-distanceX * forceKnockback, -distanceY * forceKnockback), ForceMode2D.Impulse);
        StartCoroutine(KnockbackTime(rb));
        enemiesManager.CheckAreAllEnmiesDead();
    }

    private IEnumerator KnockbackTime(Rigidbody2D enemyRb)
    {
        yield return new WaitForSeconds(forceKnockbackTime);
        enemyRb.velocity = Vector2.zero;
        if (health <= 0)
        {
            rb.bodyType = RigidbodyType2D.Static;
        }
       
    }
}
