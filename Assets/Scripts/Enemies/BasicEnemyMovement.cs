using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyMovement : MonoBehaviour
{
    public LayerMask whatIsPlayer;
    public int speed;
    public float radius;
    public float stoppingDistance;
    private GameObject player;
    public float nearDistance;
    Rigidbody2D rb;
    Vector2 roomPos;
    Vector3 roomTrans;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Room")
        {
            roomPos = col.transform.position;
            roomTrans = col.transform.localScale;
        }
    }
    // Update is called once per frame
    void Update()
    {
            if(Vector2.Distance(transform.position, player.transform.position) > stoppingDistance)
            {
            rb.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
            }
            else if(Vector2.Distance(transform.position, player.transform.position) < nearDistance)
            {
            rb.position = Vector3.MoveTowards(transform.position, player.transform.position, -speed * Time.deltaTime);
            }
            else if(Vector2.Distance(transform.position, player.transform.position) < stoppingDistance && Vector2.Distance(transform.position, player.transform.position) > nearDistance)
            {
                rb.position = this.transform.position;
            }
            //MOVE TOWARDS PLAYER
            //SHOOT AT PLAYER      
    }

}
