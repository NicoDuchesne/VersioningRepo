using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private RoomManager roomManager;
    private NumberRoomManager numberRoomManager;

    void Start()
    {
        numberRoomManager = NumberRoomManager.instance;
        numberRoomManager.SetNumberRoom();
        roomManager.ChooseRandomRoom();
    }

    IEnumerator StartGame(string currentSceneName)
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(currentSceneName);   
    }

    public void NextRoom()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        StartCoroutine(StartGame(currentSceneName));
    }
}
