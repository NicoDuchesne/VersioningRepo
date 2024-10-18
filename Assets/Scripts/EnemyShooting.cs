using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletPos;
    [SerializeField] public float speedBullet;
    [SerializeField] private float cooldown;
    [SerializeField] private float range;
    private float timer;
    private GameObject player;


    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        

        float distance = Vector2.Distance(transform.position, player.transform.position);
        //Debug.Log(distance);

        if (distance < range)
        {
            timer += Time.deltaTime;
            if (timer > cooldown)
            {
                timer = 0;
                Shoot();
            }
        }

        
    }

    private void Shoot()
    {
        GameObject newBullet = Instantiate(bullet, bulletPos.position, Quaternion.identity);
        newBullet.GetComponent<EnemyBullet>().speed = speedBullet;
    }
}
