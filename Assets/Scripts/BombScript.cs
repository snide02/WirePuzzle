using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    public GameObject player;
    public int range;

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
            Debug.Log("Boom");
        }
    }
}
