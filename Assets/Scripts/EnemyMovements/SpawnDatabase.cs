using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSpawnDatabase", menuName = "Database/Spawn", order = 0)]

public class SpawnDatabase : ScriptableObject
{
    [SerializeField] public int level;
    [SerializeField] public SpawnData SpawnNorth;
    [SerializeField] public SpawnData SpawnEast;
    [SerializeField] public SpawnData SpawnSouth;
    [SerializeField] public SpawnData SpawnWest;

}
