using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Mainmenu : MonoBehaviour
{
    public GameObject MenuPanel;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayButtonClicked()
        
    {
        Application.LoadLevel("Gameplay");

    }

    public void HowToPlayClicked()

    {
        SceneManager.LoadScene("howtoplayscene");

    }

    public void Quit_Clicked()
    {
        Application.Quit();
    }

    
}
