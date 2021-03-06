using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    public GameObject closedRooms;

    public List<GameObject> rooms;
    public float waitTime;
    private bool SpawnedBoss;
    public GameObject boss;

    void Update()
    {
        if(waitTime <= 0 && SpawnedBoss == false)
        {
            for (int i = 0; i < rooms.Count; i++)
            {
                if(i == rooms.Count -1)
                {
                    Debug.Log("BOSS SPAWNED");
                    //Instantiate(boss, rooms[i].transform.position, Quaternion.identity);
                    SpawnedBoss = true;
                }
            }
        }else
        {
            waitTime -= Time.deltaTime;
        }
    }

}
