using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeSystem : MonoBehaviour
{
public Transform attackPos;
public float attackRadius;
 public int maxObjectsHit = 5;
public Collider2D[] enemiesHit;
public LayerMask whatIsEnemy;

//Rotation Props

 
    void Start () {
        enemiesHit = new Collider2D[maxObjectsHit];
    }
 
    void Update () {
        if(Input.GetMouseButtonDown(0))        {
 
            Physics2D.OverlapCircleNonAlloc(attackPos.position, attackRadius, enemiesHit, whatIsEnemy);
            if(enemiesHit.Length > 0)  
            {
                foreach(Collider2D hit in enemiesHit)
                {
                    // REDUCE THEIR HEALTH;
                    Debug.Log("ENEMY HIT");
                }
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackPos.transform.position, attackRadius);
    }   
}