using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    public GameObject WinMenu;
    public bool outlet1 = false;
    public bool outlet2 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (outlet1 == true && outlet2 == true)
        {
            WinMenu.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }

    public void plugin1()
    {
        
    }
}