using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyMovement : MonoBehaviour
{
    public LayerMask whatIsPlayer;

    //Speed Variables
    public int speed;
    public int backSpeed;

    //Distance Checks
    public float radius;
    public float stoppingDistance;
    private GameObject player;
    public float nearDistance;
    Rigidbody2D rb;
    Vector2 roomPos;
    Vector3 roomTrans;

    //Movement Delay
    public float moveDelay;
    float timeBetweenMove;

    //Movement Check
    bool moveForward;
    bool moveBackward;
    bool still;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
    }
    // void OnCollisionEnter2D(Collision2D col)
    // {
    //     if(col.gameObject.tag == "Room")
    //     {
    //         roomPos = col.transform.position;
    //         roomTrans = col.transform.localScale;
    //     }
    // }

    void Update()
    {
            if(Vector2.Distance(transform.position, player.transform.position) > stoppingDistance)
            {
                if(timeBetweenMove <= 0)
                {
                moveForward = true;
                moveBackward = false;
                still = false;
                timeBetweenMove = moveDelay;
                }else{timeBetweenMove =- Time.deltaTime;}
            }
            else if(Vector2.Distance(transform.position, player.transform.position) < nearDistance)
            {
                timeBetweenMove = moveDelay;
                if(timeBetweenMove <= 0)
                {
                moveForward = false;
                moveBackward = true;
                still = false;
                timeBetweenMove = moveDelay;
                }else{timeBetweenMove =- Time.deltaTime;}
            }
            else if(Vector2.Distance(transform.position, player.transform.position) < stoppingDistance && Vector2.Distance(transform.position, player.transform.position) > nearDistance)
            {
                moveForward = false;
                moveBackward = false;
                still = true;
            }    
    }

    void FixedUpdate()
    {
        if(moveForward && !moveBackward && !still)
        {
                rb.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
        if(!moveForward && moveBackward && !still)
        {
                rb.position = Vector3.MoveTowards(transform.position, player.transform.position, -backSpeed * Time.deltaTime);
        }
        if(!moveForward && !moveBackward && still)
        {
                rb.position = this.transform.position;
        }
    }

}
