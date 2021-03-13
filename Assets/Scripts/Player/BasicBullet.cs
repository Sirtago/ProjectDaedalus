using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBullet : MonoBehaviour
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
        //Bullet Time Destruction
        if(shotLife <= 0)
        {
            Destroy(gameObject);
        }
        else{shotLife -= 1 * Time.deltaTime;}
    }
    //Bullet Collision
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col == null)
        {
            return;
        }
        if(col.gameObject.CompareTag("Enemy"))
        {
            //DAMAGE ENEMY
            col.gameObject.GetComponent<EnemyHealth>().TakeDamage(damageDealt);
            Destroy(gameObject);
        }
        else if(col.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}
