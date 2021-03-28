using System.Collections;
using System.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine;

public class MeleeSystem : MonoBehaviour
{
//Rotation
public Transform hitPos;
//Shooting 
[HideInInspector]
public bool canAttack;
private float timeTillNextAttack = 0;
public float AttackRate;
public LayerMask whatIsEnemy;
public float attackRadius;
public float damage;
public SpriteRenderer playerSprite;
public PlayerMovement playerMovement;
public Transform[] AttackPoints;
int direction;
    void Update () {
        //Attacking Directions
        if(Input.GetKeyDown(KeyCode.UpArrow)  )      
        {
            playerSprite.sprite = playerMovement.sprites[2];
            direction = 1;
            Melee(direction);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerSprite.sprite = playerMovement.sprites[1];
            direction = 2;
            Melee(direction);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerSprite.sprite = playerMovement.sprites[3];
            direction = 3;
            Melee(direction);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerSprite.sprite = playerMovement.sprites[0];
            direction = 4;
            Melee(direction);
        }
        
        //Time Till Next Hit
        if(timeTillNextAttack <= 0)
        {
            canAttack = true;
        }else{timeTillNextAttack -= 1 * Time.deltaTime; canAttack = false;}
        // mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    // void FixedUpdate()
    // {   //Weapon Rotation
    //     Vector2 lookDir = mousePos - new Vector2(transform.position.x, transform.position.y);
    //     angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg ;
    //     transform.rotation = Quaternion.Euler(0, 0, angle + offset);
    // }
    //Melee Class
    void Melee(int direction)
    {
        if(canAttack)
        {

            switch (direction)
            {   
                case 1:
                  hitPos.position = AttackPoints[0].position;
                  break;
                case 2:
                    hitPos.position = AttackPoints[1].position;
                    break;  
                case 3:
                    hitPos.position = AttackPoints[2].position;
                    break; 
                case 4:
                    hitPos.position = AttackPoints[3].position;
                    break; 
            }
            Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(hitPos.position, attackRadius, whatIsEnemy);
            for(int i = 0; i < enemiesToDamage.Length; i++)
            {
                Debug.Log("Hit Enemy");
                enemiesToDamage[i].GetComponent<EnemyHealth>().TakeDamage(damage);
            }
            timeTillNextAttack = AttackRate;
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(hitPos.position, attackRadius);
    }
}