using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScripts : MonoBehaviour
{
    public GameObject MainMenus;
    public GameObject SettingsMenu;

    void Start()
    {
        BackButton();
    }

    public void StartButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }

    public void SettingsButton()
    {
        MainMenus.SetActive(false);
        SettingsMenu.SetActive(true);
    }

    public void BackButton()
    {
        MainMenus.SetActive(true);
        SettingsMenu.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}