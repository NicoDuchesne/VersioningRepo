using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAwarenessController : MonoBehaviour
{
    [SerializeField] private float playerAwarenessDistance;

    public bool awareOfPlayer {  get; private set; }
    public Vector2 directionToPlayer { get; private set; }
    private Transform player;

    void Awake()
    {
        player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        Vector2 enemyToPlayerVector = player.position - transform.position;
        directionToPlayer = enemyToPlayerVector.normalized;

        if (enemyToPlayerVector.magnitude <= playerAwarenessDistance)
        {
            awareOfPlayer = true;
        } else
        {
            awareOfPlayer = false;
        }
    }

    //private void HandlePlayerTargeting()
    //{
    //    Vector3 direction = (target.position - transform.position).normalized;
    //    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    //    rb.rotation = angle;
    //    moveDirection = direction;
    //}

    //private void SetVelocity()
    //{
    //    rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
    //}
}
