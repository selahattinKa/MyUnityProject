using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void RestartGame()
    {
        Scene scene;
        scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        

    }

    public void StartGame()
    {
        //PlayerController._start.SetActive(false);
        Time.timeScale = 1;
    }

    public void NextChapter()
    {
        
    }

    public void Exit()
    {
        Application.Quit();
    }
}
