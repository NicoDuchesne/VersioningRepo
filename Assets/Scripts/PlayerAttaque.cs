using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttaque : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private float meleeSpeed;
    float timeBtwAttack;
    private void Update()
    {
        if(timeBtwAttack <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                anim.SetTrigger("Attack");
                timeBtwAttack = meleeSpeed;
            }
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }
}
