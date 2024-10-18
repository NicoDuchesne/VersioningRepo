using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerGame : MonoBehaviour
{
    [SerializeField] private NumberRoomManager numberRoomManager;

    private void Awake()
    {
        numberRoomManager = NumberRoomManager.instance;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        Destroy(numberRoomManager);
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
