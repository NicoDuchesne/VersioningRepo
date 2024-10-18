using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyBasic;
    [SerializeField] private GameObject enemyShield;
    [SerializeField] private GameObject enemyDistance;


    public void SpawnEnnemy(string type, float speed, float speedBullet)
    {
        type = type.ToLower();

        switch (type)
        {
            case "basic":
                GameObject newEnemyBasic = Instantiate(enemyBasic, transform.position, Quaternion.identity);
                newEnemyBasic.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = speed;
                break;

            case "shield":
                GameObject newEnemyShield = Instantiate(enemyShield, transform.position, Quaternion.identity);
                newEnemyShield.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = speed;
                break;

            case "distance":
                GameObject newEnemyDistance = Instantiate(enemyDistance, transform.position, Quaternion.identity);
                newEnemyDistance.GetComponent<UnityEngine.AI.NavMeshAgent>().speed = speed;
                newEnemyDistance.GetComponent<EnemyShooting>().speedBullet = speedBullet;
                break;
            default:
                Debug.Log("Erreur dans la database de la wave");
                break;
        }


        
    }
}
