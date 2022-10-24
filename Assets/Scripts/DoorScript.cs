using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject cameraObject;
    public GameObject startWaypoint;
    public GameObject endWaypoint;
    public GameObject roomManager;

    public string direction;
    
    public Animator cameraAnimator;

    public int room;
    
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
            roomManager.GetComponent<RoomManagerScript>().ActivateRoom(room);

            if (direction == "up")
            {
                collision.transform.position = new Vector2(transform.position.x, transform.position.y + 4);
                cameraObject.GetComponent<CameraScript>().startWaypoint = startWaypoint;
                cameraObject.GetComponent<CameraScript>().endWaypoint = endWaypoint;
                cameraObject.GetComponent<CameraScript>().elapsedTime = 0f;
            }
            else if (direction == "down")
            {
                collision.transform.position = new Vector2(transform.position.x, transform.position.y - 4);
                cameraObject.GetComponent<CameraScript>().startWaypoint = startWaypoint;
                cameraObject.GetComponent<CameraScript>().endWaypoint = endWaypoint;
                cameraObject.GetComponent<CameraScript>().elapsedTime = 0f;
            }
            else if (direction == "right")
            {
                collision.transform.position = new Vector2(transform.position.x + 4, transform.position.y);
                cameraObject.GetComponent<CameraScript>().startWaypoint = startWaypoint;
                cameraObject.GetComponent<CameraScript>().endWaypoint = endWaypoint;
                cameraObject.GetComponent<CameraScript>().elapsedTime = 0f;
            }
            else if (direction == "left")
            {
                collision.transform.position = new Vector2(transform.position.x - 4, transform.position.y);
                cameraObject.GetComponent<CameraScript>().startWaypoint = startWaypoint;
                cameraObject.GetComponent<CameraScript>().endWaypoint = endWaypoint;
                cameraObject.GetComponent<CameraScript>().elapsedTime = 0f;
            }
        }
    }
}