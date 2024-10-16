using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderMele : MonoBehaviour
{
    [SerializeField] private int damage;
        void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ENEMY")
        {
            collision.GetComponent<EnemyTakeDamage>().TakeDamage(damage);
            Debug.Log("Enemy Hit");
        }
    }
}
