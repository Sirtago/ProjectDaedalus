using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSnap : MonoBehaviour
{
 private GameObject cam;
 void Start()
 {
     cam = GameObject.Find("Main Camera");
 }
 void OnTriggerEnter2D(Collider2D col)
 {
     if(col.gameObject.CompareTag("Player"))
     {
        Debug.Log("SNAPPED");
        cam.transform.position = new Vector3(transform.position.x, transform.position.y, cam.transform.position.z);
     }
 }
}
