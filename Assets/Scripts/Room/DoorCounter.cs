using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCounter : MonoBehaviour
{
 public float doorCount;
bool isAdded;
 void Update()
 {
     if(doorCount == 1 && !isAdded)
     {
        GameObject.FindObjectOfType<RoomTemplates>();
     }
 }
}
