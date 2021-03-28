using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyHealth;
    public int value;
    private GameObject player;
    private GameObject gameManger;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gameManger = GameObject.FindGameObjectWithTag("Game Manager");
    }
    public void TakeDamage(float damage)
    {
        enemyHealth -= damage;
        Debug.Log("Enemy Health Left: " + enemyHealth);
        if(enemyHealth <= 0)
        {
            player.GetComponent<PlayerCurrency>().AddCurrency(value);
            Debug.Log("Enemy Killed");
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
