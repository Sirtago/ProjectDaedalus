using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
 public GameObject[] enemies;
 int rand;
void Start()
{
    rand = Random.Range(0, 11);
    if(rand > 3)
    {
    rand = Random.Range(0, enemies.Length);
    Instantiate(enemies[rand], transform.position, Quaternion.identity);
    }else{return;}
}

}
