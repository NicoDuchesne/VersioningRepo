using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]  private GameObject[] enemyPrefab;


    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            SpawnEnnemy("Basic");
        }
    }

    private void SpawnEnnemy(string type)
    {
        switch (type)
        {
            case "Basic":
                GameObject enemyBasic = Instantiate(enemyPrefab[0], transform.position, Quaternion.identity);
                break;

            case "Shield":
                GameObject enemyShield = Instantiate(enemyPrefab[1], transform.position, Quaternion.identity);
                break;

            case "Distance":
                GameObject enemyDistance = Instantiate(enemyPrefab[2], transform.position, Quaternion.identity);
                break;
        }
        
    }
}
