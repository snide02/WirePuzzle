using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
