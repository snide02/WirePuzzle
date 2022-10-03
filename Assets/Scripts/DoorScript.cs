using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject otherDoor;
    public string direction;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {      
        if(collision.gameObject.tag == "Player")
        {
            if(direction == "up")
            {
                collision.transform.position = new Vector2(transform.position.x, transform.position.y + 2);
            }
            else if (direction == "down")
            {
                collision.transform.position = new Vector2(transform.position.x, transform.position.y - 2);
            }
            else if (direction == "right")
            {
                collision.transform.position = new Vector2(transform.position.x + 2, transform.position.y);
            }
            else if (direction == "left")
            {
                collision.transform.position = new Vector2(transform.position.x - 2, transform.position.y);
            }
        }
    }
}
