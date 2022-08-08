using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool IsPaused = false;
    public GameObject pauseMenuUI;

    void Start()
    {
        pauseMenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    // replay the game
    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }
    
    // Pause the game
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }

    
    // buttons
    public void back2main()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scenes/main_menu");
    }
    
    public void play()
    {
        Resume();
    }
    
    public void reload()
    {
        SceneManager.LoadScene("Scenes/test_level");
        Resume();
    }
    
    public void setting()
    {
        Debug.Log("Setting...");
    }
    
    public void select()
    {
        SceneManager.LoadScene("Scenes/Select_menu");
    }
}
