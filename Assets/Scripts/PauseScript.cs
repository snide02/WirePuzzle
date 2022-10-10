using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public GameObject PauseMenu;
    bool pause = false;
    

    void Start()
    {
        PauseMenu.SetActive(false);
    }

    void Update()
    {
         if (Input.GetKeyDown ("escape")) {
             if(pause == true){
                 Time.timeScale = 1.0f;
                 PauseMenu.SetActive(false);
                 pause = false;
             } else {
                 Time.timeScale = 0.0f;
                 PauseMenu.SetActive(true);
                 pause = true;
             }
         }
    }

    public void RestartButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
        Time.timeScale = 1.0f;
    }
    public void MainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1.0f;
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}