using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // buttons
    public void back2main()
    {
        SceneManager.LoadScene("Scenes/main_menu");
    }
    
    public void selectLevel()
    {
        SceneManager.LoadScene("Scenes/test_level");
        Time.timeScale = 1f;
    }
}
