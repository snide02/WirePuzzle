using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public float speed;

    public PlayerHitScript playerHitScript;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.timeScale, Space.Self);
    }

    void OnCollisionEnter2D(Collision2D collsion)
    {
        if (collsion.gameObject.tag == "Projectile")
        {
            Destroy(collsion.gameObject);
        }
        else if(collsion.gameObject.tag == "Enemy")
        {
            Destroy(collsion.gameObject);
        }
        /*else if (collsion.gameObject.tag == "Player")
        {
            Destroy(collsion.gameObject);
        }*/

        Destroy(this.gameObject);
    }
}
