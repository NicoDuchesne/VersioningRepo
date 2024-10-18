using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerGame : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
