using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BombScript : MonoBehaviour
{
    public GameObject player;
    public int range;

    public GameObject LoseMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        detectPlayer();
    }

    void detectPlayer()
    {
        if (Vector2.Distance(transform.position, player.transform.position) < range)
        {
            LoseMenu.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }
}
