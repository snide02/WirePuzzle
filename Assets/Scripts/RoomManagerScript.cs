using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManagerScript : MonoBehaviour
{
    public GameObject[] rooms;
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 1; i < rooms.Length; i++)
        {
            rooms[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateRoom(int room)
    {
        rooms[room - 1].SetActive(true);
    }
}
