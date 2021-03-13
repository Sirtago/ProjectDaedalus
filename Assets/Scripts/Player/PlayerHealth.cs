using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public void TakeDamge(int damage)
    {
        health = health - damage;
        if(health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        //Destroy(gameObject);
        foreach (Transform child in transform)
            {
            child.gameObject.SetActive(false);
            }
        gameObject.GetComponent<PlayerMovement>().canMove = false;
    }
}