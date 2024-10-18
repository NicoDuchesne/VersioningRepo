using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    private GameObject[] rooms;
    [SerializeField] private GameObject RoomContainer;
    private int previusRandomRoom = 0;

    private void Awake()
    {
        rooms = new GameObject[RoomContainer.transform.childCount];
        for (int i = 0; i < RoomContainer.transform.childCount; i++)
        {
            rooms[i] = RoomContainer.transform.GetChild(i).gameObject;
        }
    }

    public void ChooseRandomRoom()
    {
        int randomRoom = Random.Range(0, rooms.Length);
        rooms[previusRandomRoom].SetActive(false);
        rooms[randomRoom].SetActive(true);
        Debug.Log(" Current Room: " + randomRoom);
        previusRandomRoom = randomRoom;
    }

}
