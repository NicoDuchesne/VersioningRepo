using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodSplash : MonoBehaviour
{
    [SerializeField] private float timeBloodSplash;

  
    void Update()
    {
        Destroy(gameObject, timeBloodSplash);
    }
}
