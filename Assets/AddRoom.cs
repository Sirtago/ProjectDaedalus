using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRoom : MonoBehaviour
{
  private RoomTemplates templates;
  public int doorCounter;
  bool isAddedS = false;
  bool isAdded = false;
  void Start()
  {
    templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
  }
  void Update()
  {
    if(doorCounter == 1 && !isAddedS)
    {
      templates.specialRooms.Add(this.gameObject);
      isAddedS = true;
    }
    if(!isAdded)
    {
      templates.roomCount.Add(this.gameObject);
      isAdded = true;
    }
  }
}
