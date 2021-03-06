using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int openingDirection;
    private RoomTemplates templates;
    int rand;
    public bool isSpawned;
    // Start is called before the first frame update
    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn", 0.1f);
    }

    // Update is called once per frame
    void Spawn()
    {
        if(isSpawned == false){
        if(openingDirection == 1)
        {
            rand = Random.Range(0, templates.bottomRooms.Length);
            Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
        }
        else if(openingDirection == 2)
        {
            rand = Random.Range(0, templates.topRooms.Length);
            Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);
        }
        else if(openingDirection == 3)
        {
            rand = Random.Range(0, templates.leftRooms.Length);
            Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);
        }
        else if(openingDirection == 4)
        {
            rand = Random.Range(0, templates.rightRooms.Length);
            Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
        }
        isSpawned = true;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("SpawnPoint"))
        {
            if(col.GetComponent<RoomSpawner>().isSpawned == false && isSpawned == false)
            {
                //Spawn wall to block opening
                Instantiate(templates.closedRooms, transform.position, templates.closedRooms.transform.rotation);
                Destroy(gameObject);
            }
                isSpawned = true;
        }
    }
}
