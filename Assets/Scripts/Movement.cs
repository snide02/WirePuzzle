using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    bool key;
    Vector2 mousePosition;
    void Update()
    {
        // Move to mouse click position
        if (Input.GetMouseButtonDown(0)){
            key = false;
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if (mousePosition != Vector2.zero && key == false){
            transform.position = Vector2.MoveTowards(transform.position, mousePosition, moveSpeed * Time.deltaTime);
        }

        //Movement based on four directions
        if (Input.GetKey("down")){
            key = true;
            transform.Translate(0, (-1 * Time.deltaTime * moveSpeed), 0);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if (Input.GetKey("up")){
            key = true;
            transform.Translate(0, (1 * Time.deltaTime * moveSpeed), 0);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if (Input.GetKey("left")){
            key = true;
            transform.Translate((-1 * Time.deltaTime * moveSpeed), 0, 0);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if (Input.GetKey("right")){
            key = true;
            transform.Translate((1 * Time.deltaTime * moveSpeed), 0, 0);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
    }
}
