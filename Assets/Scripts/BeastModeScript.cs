using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeastModeScript : MonoBehaviour
{
    public bool beastMode;
    
    // Start is called before the first frame update
    void Start()
    {
        if (beastMode == true)
        {
            Time.timeScale = 10f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
