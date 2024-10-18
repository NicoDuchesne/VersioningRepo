using System.Collections;
using System.Collections.Generic;
//using UnityEditor.PackageManager;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    public bool AreAllEnmiesDead;

    private void Awake()
    {
        AreAllEnmiesDead = false;
    }
    public void CheckAreAllEnmiesDead()
    {
        GameObject[] ntm = GameObject.FindGameObjectsWithTag("ENEMY");
        if(GameObject.FindGameObjectsWithTag("ENEMY").Length == 0)
        {
            AreAllEnmiesDead = true; 
            Debug.Log("All enemies are dead");
        }
    }
}
