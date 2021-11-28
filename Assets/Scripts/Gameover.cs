using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    public GameObject MenuPanel;

    public void RestartButtonClicked()
    {
        Application.LoadLevel("Gameplay");
    }

    public void MainMenuButtonClicked()
    {
        Application.LoadLevel("MainMenu");
    }

    public void Quit_Clicked()
    {
        Application.Quit();
    }
}
