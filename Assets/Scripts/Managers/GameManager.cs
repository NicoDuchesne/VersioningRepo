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
        string currentSceneName = SceneManager.GetActiveScene().name;
        numberRoomManager = NumberRoomManager.instance;
        numberRoomManager.SetNumberRoom();
        roomManager.ChooseRandomRoom();
        StartCoroutine(StartGame(currentSceneName));
    }

    IEnumerator StartGame(string currentSceneName)
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(currentSceneName);   
    }
}
