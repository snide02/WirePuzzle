using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutletScript : MonoBehaviour
{
    public GameObject player;

    public Vector2 size;

    public LayerMask playerLayer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, size);
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D[] detectPlayer = Physics2D.OverlapBoxAll(transform.position, size, playerLayer);
        Debug.Log(detectPlayer.Length);

        if (detectPlayer.Length > 0)
        {
            Debug.Log("Wire Connected");
        }
    }
}