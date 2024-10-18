using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberRoomManager : MonoBehaviour
{
    public static NumberRoomManager instance;

    public int numberRoom;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void SetNumberRoom()
    {
        numberRoom +=1;
        Debug.Log("Number of rooms: " + numberRoom);
    }

    public void ResetNumberRoom()
    {
        numberRoom = 0;
    }

}
