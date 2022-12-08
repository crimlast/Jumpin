using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject p;
    public bool paused;

    void Start()
    {
        p.SetActive(false);
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(paused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    public void PauseGame()
    {
        p.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }

    public void ResumeGame()
    {
        p.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }

    public void EndGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
