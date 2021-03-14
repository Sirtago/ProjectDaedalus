using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRoom : MonoBehaviour
{
  private RoomTemplates templates;
  public int doorCounter;
  bool isAdded;

  void Start()
  {
    templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
  }
  void Update()
  {
    if(doorCounter == 1 && !isAdded)
    {
      templates.specialRooms.Add(this.gameObject);
      isAdded = true;
    }
  }
}
