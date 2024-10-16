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
}
