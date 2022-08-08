using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public GameObject endMenuUI;

    void Start()
    {
        endMenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //这一段还有问题
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cube")
        {
            endMenuUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    //----
    
    // replay the game
    void Resume()
    {
        endMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
    
   
    // buttons
    public void back2main()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scenes/main_menu");
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