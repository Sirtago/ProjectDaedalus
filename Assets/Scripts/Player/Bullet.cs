using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    public float damageDealt;
    public float shotLife;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * bulletSpeed;
    }

    void Update()
    {
        if(shotLife <= 0)
        {
            Destroy(gameObject);
        }
        else{shotLife -= 1;}
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Enemy"))
        {
            //DAMAGE ENEMY
        }
        if(col.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
