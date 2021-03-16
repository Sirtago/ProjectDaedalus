using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour
{
  public float loadingTime;

    void Update()
    {
        if(loadingTime <= 0)
        {
            FindObjectOfType<ShootingSystem>().canShootBasic = true;
            FindObjectOfType<PlayerMovement>().canMove = true;  
            Destroy(gameObject);
        }else
        {
            loadingTime -= 1 * Time.deltaTime;
            FindObjectOfType<ShootingSystem>().canShootBasic = false;
            FindObjectOfType<PlayerMovement>().canMove = false;    
        }
    }
}
