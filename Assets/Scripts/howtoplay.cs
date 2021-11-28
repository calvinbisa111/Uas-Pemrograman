using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class howtoplay : MonoBehaviour
{
    public GameObject MenuPanel; 

    public void BackbuttonClicked()
    {
        Application.LoadLevel("MainMenu");
    }
}
