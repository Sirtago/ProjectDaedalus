using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public float fireRate;
    private float timeBTWShots;
    public GameObject enemyBullet;
    public Transform shotPos;
    GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        timeBTWShots = fireRate;
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
    EnemyShoot();
    Vector3 dir = target.transform.position - transform.position; 
    float angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg; 
    transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
     timeBTWShots -= 1 * Time.deltaTime;
    }
    public void EnemyShoot()
    {
        if(timeBTWShots <= 0)
        {
        Instantiate(enemyBullet, shotPos.transform.position, transform.rotation);
        timeBTWShots = fireRate;
        }else{return;}
    }
}
