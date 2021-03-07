using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeSystem : MonoBehaviour
{
public Camera cam;
//Rotation Props
private Vector2 mousePos;
public GameObject bullet;
public Transform shootPos;
    void Update () {
        if(Input.GetMouseButtonDown(0))        
        {
            Shoot();
        }
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

    }
    void FixedUpdate()
    {
        Vector2 lookDir = mousePos - new Vector2(transform.position.x, transform.position.y);
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg ;
        transform.rotation = Quaternion.Euler(0, 0, angle);

    }
    void Shoot()
    {
        Instantiate(bullet, shootPos.transform.position, transform.rotation);
    }
}