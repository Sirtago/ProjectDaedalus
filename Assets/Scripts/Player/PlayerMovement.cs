using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    [HideInInspector]
    public bool canMove;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    //Player Movement Input
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        moveVelocity = moveInput.normalized * speed;
    }
    //Character Movement Physics
    void FixedUpdate()
    {
        if(canMove)
        {
       rb.position = rb.position + moveVelocity * Time.deltaTime;
        }
    }
}
