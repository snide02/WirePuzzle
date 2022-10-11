using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeastModeScript : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Update()
    {
        Time.timeScale = 10f;
    }
}
