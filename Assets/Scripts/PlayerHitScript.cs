using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitScript : MonoBehaviour
{
    public float attackSpeed;
    private float xPos, yPos, sideA, sideB, zAngle = 0f;
    private Vector3 currentPosition;
    private Vector3 previousPosition;
    private bool isEnemies;

    public GameObject playerProjectile;
    
    
    [SerializeField] private LayerMask enemyLayer;

    // Start is called before the first frame update
    void Start()
    {
        previousPosition = new Vector3(transform.position.x, transform.position.y, zAngle);

        InvokeRepeating("checkIfMoving", attackSpeed, attackSpeed);
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
        if (isEnemies){
            GameObject projectileClone = Instantiate(playerProjectile, playerProjectile.transform.position, playerProjectile.transform.rotation);
            projectileClone.SetActive(true);
        }
        
    }

    void checkIfMoving()
    {
        currentPosition = new Vector3(transform.position.x, transform.position.y, zAngle);
        if(currentPosition == previousPosition)
        {
            pointToEnemy();
            Attack();
        }
        previousPosition = currentPosition;
    }

    void pointToEnemy()
    {
        Collider2D[] coll = Physics2D.OverlapCircleAll(transform.position, 20f, enemyLayer);
        List<GameObject> enemies = new List<GameObject>(5);
        for (int i = 0; i < coll.Length; i++) {
            enemies.Add(coll[i].gameObject);
        }
        GameObject targetEnemy;
        
        

        if (enemies.Count != 0)
        {
            isEnemies = true;
            targetEnemy = enemies[0];

            for (int i = 0; i < enemies.Count; i++)
            {
                if (Vector2.Distance(transform.position, enemies[i].transform.position) < Vector2.Distance(transform.position, targetEnemy.transform.position))
                {
                    targetEnemy = enemies[i];
                }
            }

            xPos = targetEnemy.transform.position.x;
            yPos = targetEnemy.transform.position.y;
            sideA = transform.position.x - xPos;
            sideB = transform.position.y - yPos;

            zAngle = Mathf.Atan2(sideB, sideA) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0f, 0f, zAngle);
        } else {
            isEnemies = false;
        }

    }
}
