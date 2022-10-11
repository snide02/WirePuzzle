using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    public int outletCounter = 0;

    public GameObject WinMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void plugin()
    {
        outletCounter++;

        if(outletCounter == 2)
        {
            WinMenu.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }
}