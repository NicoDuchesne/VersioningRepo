using System.Collections;
using System.Collections.Generic;
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
        if(GameObject.FindGameObjectsWithTag("ENEMY") == null)
        {
            AreAllEnmiesDead = true;
        } 
    }
}
