using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerGame : MonoBehaviour
{
    [SerializeField] private NumberRoomManager numberRoomManager;
    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        numberRoomManager.ResetNumberRoom();
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
