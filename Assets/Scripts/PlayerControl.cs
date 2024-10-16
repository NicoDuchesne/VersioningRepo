using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 10.0f;
    float speedx, speedz;
    Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        speedx = Input.GetAxis("Horizontal") * speed;
        speedz = Input.GetAxis("Vertical") * speed;
        rb.velocity = new Vector2(speedx, speedz);
    }
}
