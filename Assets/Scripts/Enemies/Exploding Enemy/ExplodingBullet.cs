using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingBullet : MonoBehaviour
{
 public float bulletSpeed;
    public int damageDealt;
    public float shotLife;
    private Rigidbody2D rb;
    public Transform[] shotPoints;
    public GameObject normalBullet;
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
            foreach(Transform shotpoint in shotPoints)
            {
                Instantiate(normalBullet, shotpoint.position, shotpoint.rotation);
            }
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
        if(col.gameObject.CompareTag("Player"))
        {
            //DAMAGE ENEMY
            col.gameObject.GetComponent<PlayerHealth>().TakeDamge(damageDealt);
            Destroy(gameObject);
        }
        else if(col.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
        else if(col.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
