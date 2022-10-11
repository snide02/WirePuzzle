using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutletScript : MonoBehaviour
{
    public GameObject player;
    public int range;
    private bool wireConnectable = false;

    public GameObject winManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        detectPlayer();
        connectWire();
    }

    void detectPlayer()
    {
        if(Vector2.Distance(transform.position, player.transform.position) < range)
        {
            Debug.Log("Press E to connect wire");
            wireConnectable = true;
        }
        else
        {
            wireConnectable = false;
        }
    }

    void connectWire()
    {
        if(wireConnectable == true)
        {
            //Display UI asking to connect the wire

            if(Input.GetKeyDown("e"))
            {
                winManager.GetComponent<WinScript>().plugin();
            }
        }
        else
        {
            //Hide UI asking to connect the wire
        }
    }
}