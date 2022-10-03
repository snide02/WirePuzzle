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
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);

            //if (mousePosition != Vector2.zero)
            {
                transform.position = Vector2.Lerp(transform.position, mousePosition, Time.deltaTime);
            }
        }
        //else
        {
            float hor = Input.GetAxisRaw("Horizontal");
            float ver = Input.GetAxisRaw("Vertical");

            rb.velocity = new Vector2(hor * moveSpeed, ver * moveSpeed);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        } 
    }
}
