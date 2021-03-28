using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSystem : MonoBehaviour
{
public Camera cam;
//Rotation
private Vector2 mousePos;
public Transform shootPos;
//Shooting 
public GameObject bullet;

[HideInInspector]
public bool canShootBasic;
private float timeTillNextShot = 0;
public float basicFireRate;
public Transform gunSprite;
bool isFlipped;
float angle;
    void Update () {
        //Weapon Shooting
        if(Input.GetMouseButtonDown(0))        
        {
            BasicShoot();
        }
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        //Time Till Next Shot
        if(timeTillNextShot <= 0)
        {
            canShootBasic = true;
        }else{timeTillNextShot -= 1 * Time.deltaTime; canShootBasic = false;}
        
        if(angle > 90 && isFlipped)
        {
        angle = -angle;
        isFlipped = false;
            Flip();
        }
        if(angle < -90 && !isFlipped)
        {
        isFlipped = true;
            angle = -angle;
            Flip();
        }
    }
    void FixedUpdate()
    {   //Weapon Rotation
        Vector2 lookDir = mousePos - new Vector2(transform.position.x, transform.position.y);
        angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg ;
        transform.rotation = Quaternion.Euler(0, 0, angle);

    }
    //Shooting Class
    void BasicShoot()
    {
        if(canShootBasic)
        {
        FindObjectOfType<AudioManager>().Play("GunShot");
        Instantiate(bullet, shootPos.transform.position, transform.rotation);
        timeTillNextShot = basicFireRate;
        }
    }
    void Flip()
    {
        if(isFlipped)
        {
            gunSprite.localRotation = Quaternion.Euler(-180, 0, 0);
        }else{ gunSprite.localRotation = Quaternion.Euler(0,0, 0);}
    }
}