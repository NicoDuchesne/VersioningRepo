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
    public void LaunchWave(int level)
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
        StartCoroutine(spawnWave(SpawnDB, speedByLevel[level - 1], bulletSpeedByLevel[level - 1]));
    }

    IEnumerator spawnWave(SpawnDatabase SpawnDB, float speed, float speedBullet)
    {
        foreach(string enemy in SpawnDB.SpawnNorth.enemies)
        {
            SpawnerNorth.SpawnEnnemy(enemy, speed, speedBullet);
            yield return new WaitForSeconds(0.5f);
        }
        foreach (string enemy in SpawnDB.SpawnEast.enemies)
        {
            SpawnerEast.SpawnEnnemy(enemy, speed, speedBullet);
            yield return new WaitForSeconds(0.5f);
        }
        foreach (string enemy in SpawnDB.SpawnSouth.enemies)
        {
            SpawnerSouth.SpawnEnnemy(enemy, speed, speedBullet);
            yield return new WaitForSeconds(0.5f);
        }
        foreach (string enemy in SpawnDB.SpawnWest.enemies)
        {
            SpawnerWest.SpawnEnnemy(enemy, speed, speedBullet);
            yield return new WaitForSeconds(0.5f);
        }
    }

}
