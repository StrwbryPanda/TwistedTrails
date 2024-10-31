using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    // Scene Control for buttons
    public void selectEasyMazeScene()
    {
        SceneManager.LoadScene("EasyMaze");
    }
    
    public void selectHardMazeScene()
    {
        SceneManager.LoadScene("HardMaze");
    }

    public void selectMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitApplication()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}