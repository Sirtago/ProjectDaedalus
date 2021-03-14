using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    public GameObject closedRooms;

    public List<GameObject> specialRooms;
    public float waitTime;
    public GameObject boss;
    public GameObject shop;
    [HideInInspector]
    public bool SpawnedBoss;

    void Update()
    {
        if(waitTime <= 0 && SpawnedBoss == false)
        {
     if(specialRooms.Count < 2)
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
            for (int i = 0; i < specialRooms.Count; i++)
            {
                if(i == specialRooms.Count -1)
                {
                    Instantiate(boss, specialRooms[i].transform.position, Quaternion.identity);
                    Instantiate(shop, specialRooms[i - 1].transform.position, Quaternion.identity);    
                    SpawnedBoss = true;
                }
            }
        }else
        {
            waitTime -= Time.deltaTime;
        }
    }
}
