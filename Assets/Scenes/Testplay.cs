using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testplay : MonoBehaviour
{
    public float MovementSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var movementX = Input.GetAxis("Horizontal");
        var movementY = Input.GetAxis("Vertical");
        transform.position += new Vector3(movementX, movementY , 0) * Time.deltaTime * MovementSpeed;
    }
}
