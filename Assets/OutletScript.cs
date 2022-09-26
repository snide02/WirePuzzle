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

    // Update is called once per frame
    void Update()
    {
        Collider2D[] detectPlayer = Physics2D.OverlapBoxAll(transform.position, size, playerLayer);

        for(int i = 0; i < detectPlayer.Length; i++)
        {
            if(detectPlayer[i] == player)
            {
                Debug.Log("Wire Secured");
            }
        }
    }
}
