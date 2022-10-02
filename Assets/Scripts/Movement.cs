using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    bool key;
    Vector2 mousePosition;
    public Rigidbody2D rb;

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

        /*//Movement based on four directions
        if (Input.GetKey("down")){
            key = true;
            //transform.Translate(0, (-1 * Time.deltaTime * moveSpeed), 0);
            rb.velocity = new Vector2(0, (-1 * moveSpeed));
            transform.eulerAngles = new Vector3(0f, 0f, 0f);

        }
        if (Input.GetKey("up")){
            key = true;
            //transform.Translate(0, (1 * Time.deltaTime * moveSpeed), 0);
            rb.velocity = new Vector2(0, (moveSpeed));
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if (Input.GetKey("left")){
            key = true;
            //transform.Translate((-1 * Time.deltaTime * moveSpeed), 0, 0);
            rb.velocity = new Vector2((-1 * moveSpeed), 0);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if (Input.GetKey("right")){
            key = true;
            //transform.Translate((1 * Time.deltaTime * moveSpeed), 0, 0);
            rb.velocity = new Vector2((moveSpeed), 0);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }*/

        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(hor * moveSpeed, ver * moveSpeed);
        transform.eulerAngles = new Vector3(0f, 0f, 0f);
    }
}
