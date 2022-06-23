using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public GameObject HTPCanvas;

    public void HowToPlay()
    {
        mainMenuCanvas.SetActive(false);
        HTPCanvas.SetActive(true);
    }

    public void GoToMenu()
    {
        mainMenuCanvas.SetActive(true);
        HTPCanvas.SetActive(false);
    }
}
