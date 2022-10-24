using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutletScript : MonoBehaviour
{
    public GameObject player;
    public GameObject winManager;
    public GameObject outletUI;

    public int range;
    public int outletNumber;

    private bool wireConnectable = false;


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
            if(Input.GetKeyDown("e"))
            {
                if (outletNumber == 1)
                {
                    winManager.GetComponent<WinScript>().outlet1 = true;
                }
                else
                {
                    winManager.GetComponent<WinScript>().outlet2 = true;
                }
            }

            outletUI.SetActive(true);
        }
        else
        {
            outletUI.SetActive(false);
        }
    }
}