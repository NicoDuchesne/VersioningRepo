using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderMele : MonoBehaviour
{
        void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ENEMY")
        {
            //collision.GetComponent<Enemy>().TakeDamage(damage);
            Debug.Log("Enemy Hit");
        }
    }
}
