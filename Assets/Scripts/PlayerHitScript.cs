using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitScript : MonoBehaviour
{
    public float attackSpeed;

    private Vector3 currentPosition;
    private Vector3 previousPosition;

    public GameObject playerProjectile;
    public GameObject[] enemies;

    public int enemiesAmount = 2;

    // Start is called before the first frame update
    void Start()
    {
        previousPosition = transform.position;

        InvokeRepeating("checkIfMoving", attackSpeed, attackSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collsion)
    {
        if (collsion.gameObject.tag == "Projectile")
        {
            //Debug.Log("Player hit");
            Destroy(collsion.gameObject);
        }
    }

    void Attack()
    {
        GameObject projectileClone = Instantiate(playerProjectile, playerProjectile.transform.position, playerProjectile.transform.rotation);
        projectileClone.SetActive(true);
    }

    void checkIfMoving()
    {
        currentPosition = transform.position;
        if(currentPosition == previousPosition)
        {
            pointToEnemy();
            Attack();
        }

        previousPosition = currentPosition;
    }

    void pointToEnemy()
    {
        GameObject targetEnemy;
        
        if (enemies.Length != 0)
        {
            targetEnemy = enemies[0];

            for (int i = 1; i < enemiesAmount; i++)
            {
                if (Vector2.Distance(transform.position, enemies[i].transform.position) < Vector2.Distance(transform.position, targetEnemy.transform.position))
                {
                    targetEnemy = enemies[i];
                }
            }

            float xPos = targetEnemy.transform.position.x;
            float yPos = targetEnemy.transform.position.y;

            float sideA = transform.position.x - xPos;
            float sideB = transform.position.y - yPos;

            float zAngle = Mathf.Atan2(sideB, sideA) * Mathf.Rad2Deg;

            transform.eulerAngles = new Vector3(0f, 0f, zAngle);
        }
    }
}
