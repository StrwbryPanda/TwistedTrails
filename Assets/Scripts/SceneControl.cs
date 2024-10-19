using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void selectEasyMazeScene()
    {
        SceneManager.LoadScene("EasyMaze");
    }
    
    public void selectHardMazeScene()
    {
        SceneManager.LoadScene("HardMaze");
    }
    
}
