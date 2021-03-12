using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
 public GameObject[] enemies;
 EnemyLoader enemyLoader;
 CameraSnap cameraSnap;
 Transform prefabTrans;
 int rand;
void Start()
{
    enemyLoader = GetComponentInParent<EnemyLoader>();
    cameraSnap = GetComponentInParent<CameraSnap>();
    rand = Random.Range(0, 11);
    if(rand > 3)
    {
    rand = Random.Range(0, enemies.Length);
    GameObject enemy = Instantiate(enemies[rand], transform.position, Quaternion.identity);
    enemyLoader.enemyGameObject.Add(enemy);
    prefabTrans = enemy.GetComponent<Transform>();
    }
}
    void Update()
    {
        // if(!cameraSnap.isSnapped)
        // {
        //     prefabTrans.position = transform.position;
        // }
    }

}
