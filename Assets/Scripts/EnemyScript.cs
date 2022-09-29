using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject projectile;
    public GameObject player;

    public int shootSpeed;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shoot", shootSpeed, shootSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        pointToPlayer();
    }

    void pointToPlayer()
    {
        float xPos = player.transform.position.x;
        float yPos = player.transform.position.y;

        float sideA = transform.position.x - xPos;
        float sideB = transform.position.y - yPos;

        float zAngle = Mathf.Atan2(sideB, sideA) * Mathf.Rad2Deg;

        transform.eulerAngles = new Vector3(0f, 0f, zAngle);
    }

    void shoot()
    {
        GameObject projectileClone = Instantiate(projectile, projectile.transform.position, projectile.transform.rotation);
        projectileClone.SetActive(true);
    }
}
