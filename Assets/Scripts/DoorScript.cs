using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject otherDoor;

    public string direction;
    
    public Animator cameraAnimator;
    
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
                collision.transform.position = new Vector2(transform.position.x, transform.position.y + 3);
                cameraAnimator.SetTrigger("moveUp");
            }
            else if (direction == "down")
            {
                collision.transform.position = new Vector2(transform.position.x, transform.position.y - 3);
                cameraAnimator.SetTrigger("moveDown");
            }
            else if (direction == "right")
            {
                collision.transform.position = new Vector2(transform.position.x + 3, transform.position.y);
                cameraAnimator.SetTrigger("moveRight");
            }
            else if (direction == "left")
            {
                collision.transform.position = new Vector2(transform.position.x - 3, transform.position.y);
                cameraAnimator.SetTrigger("moveLeft");
            }
        }
    }
}
