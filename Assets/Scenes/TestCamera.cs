using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCamera : MonoBehaviour
{
    public Transform traget;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = traget.position + offset;
    }
}
