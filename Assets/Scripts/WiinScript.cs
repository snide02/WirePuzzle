using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiinScript : MonoBehaviour
{
    public int outletCounter = 0;

    public GameObject youWinText;
    
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
            youWinText.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
