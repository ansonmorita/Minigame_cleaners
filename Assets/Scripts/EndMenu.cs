using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndMenu : MonoBehaviour
{
    public GameObject endMenuUI;

    [SerializeField] Text scoreTxt;
    void Start()
    {
        scoreTxt.text = PlayerMovement.score.ToString();
    }

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Debug.Log("finish!!");
            Time.timeScale = 0f;
            //endMenuUI.SetActive(true);
        }
    }
  
    
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
        PlayerMovement.score = 0;
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