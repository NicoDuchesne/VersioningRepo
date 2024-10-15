using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBottomRotation : MonoBehaviour
{
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            Vector2 direction = new Vector2(
                Input.GetAxis("Horizontal"),
                Input.GetAxis("Vertical")
            );

            transform.up = direction;
        }
    }
}
