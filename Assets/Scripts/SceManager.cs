using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceManager : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }
    public void Replay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
