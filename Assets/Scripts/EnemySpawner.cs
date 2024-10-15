using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]  private GameObject enemyPrefab;


    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            SpawnEnnemy(enemyPrefab);
        }
    }

    private void SpawnEnnemy(GameObject enemyPrefab)
    {
        GameObject enemy = Instantiate(enemyPrefab, new Vector3(transform.position.x, transform.position.y, 0f), Quaternion.identity);
    }
}
