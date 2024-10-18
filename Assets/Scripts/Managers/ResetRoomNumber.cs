using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetRoomNumber : MonoBehaviour
{
    private NumberRoomManager numberRoomManager;

    void Start()
    {
        numberRoomManager = NumberRoomManager.instance;
    }

    public void RestartGame()
    {
        numberRoomManager.ResetNumberRoom();
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
