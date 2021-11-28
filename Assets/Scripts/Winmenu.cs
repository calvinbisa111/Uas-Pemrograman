using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Winmenu : MonoBehaviour
{
    public GameObject MenuPanel;

    public void MainMenuButtonClicked()
    {
        Application.LoadLevel("MainMenu");
    }

    public void Quit_Clicked()
    {
        Application.Quit();
    }
}
