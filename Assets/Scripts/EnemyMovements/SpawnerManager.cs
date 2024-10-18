using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    [SerializeField] private EnemySpawner SpawnerNorth;
    [SerializeField] private EnemySpawner SpawnerEast;
    [SerializeField] private EnemySpawner SpawnerSouth;
    [SerializeField] private EnemySpawner SpawnerWest;

    [SerializeField] private SpawnDatabase[] SpawnDatabase;
    [SerializeField] private float[] speedByLevel;
    [SerializeField] private float[] bulletSpeedByLevel;
    private float speed;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            LaunchWave(3);
        }

    }

    private void LaunchWave(int level)
    {
        bool foundDB = false;
        SpawnDatabase SpawnDB;
        do
        {
            int randomIndex = Random.Range(0, SpawnDatabase.Length);
            SpawnDB = SpawnDatabase[randomIndex];
            if (SpawnDB.level == level)
                foundDB = true;
        } while (!foundDB);

        spawnWave(SpawnDB, speedByLevel[level-1], bulletSpeedByLevel[level - 1]);
    }

    private void spawnWave(SpawnDatabase SpawnDB, float speed, float speedBullet)
    {
        foreach(string enemy in SpawnDB.SpawnNorth.enemies)
        {
            SpawnerNorth.SpawnEnnemy(enemy, speed, speedBullet);
        }
        foreach (string enemy in SpawnDB.SpawnEast.enemies)
        {
            SpawnerEast.SpawnEnnemy(enemy, speed, speedBullet);
        }
        foreach (string enemy in SpawnDB.SpawnSouth.enemies)
        {
            SpawnerSouth.SpawnEnnemy(enemy, speed, speedBullet);
        }
        foreach (string enemy in SpawnDB.SpawnWest.enemies)
        {
            SpawnerWest.SpawnEnnemy(enemy, speed, speedBullet);
        }
    }

}
