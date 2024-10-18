using System.Collections;
using System.Collections.Generic;
//using UnityEditor.SearchService;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private RoomManager roomManager;
    private NumberRoomManager numberRoomManager;
    [SerializeField] private TextMeshProUGUI currentRoom;
    [SerializeField] private EnemiesManager enemiesManager;
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private GameObject DeathScreen;
    [SerializeField] private TextMeshProUGUI nbRoomDeathText;
    [SerializeField] private SpawnerManager spawnerManager;
    private int level = 1;

    void Start()
    {
        numberRoomManager = NumberRoomManager.instance;
        numberRoomManager.SetNumberRoom();
        if (numberRoomManager.numberRoom > 5 && numberRoomManager.numberRoom < 12)
        {
            level = 2;
        }
        else if (numberRoomManager.numberRoom >= 12)
        {
            level = 3;
        }
        currentRoom.text = "Room: " + numberRoomManager.numberRoom;
        nbRoomDeathText.text = "Room: " + numberRoomManager.numberRoom;
        roomManager.ChooseRandomRoom();
        StartSpawnEnemies(level);
    }

    void Update()
    {
        if (playerHealth.health <= 0)
        {
            DeathScreen.SetActive(true);
            this.enabled = false;
        }
        if (enemiesManager.AreAllEnmiesDead)
        {
            StartCoroutine(NextRoom());
            Debug.Log("Next Room");
        }
    }

    IEnumerator StartGame(string currentSceneName)
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(currentSceneName);   
    }

    IEnumerator NextRoom()
    {
        yield return new WaitForSeconds(1.5f);
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

    public void  StartSpawnEnemies(int level)
    {
        
        spawnerManager.LaunchWave(level);
    }
}
