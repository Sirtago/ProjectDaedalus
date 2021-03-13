using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopkeeperInteract : MonoBehaviour
{
    public bool canInteract;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == ("Player"))
        {
            canInteract = true;
            Debug.Log("Windows Open");

        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        canInteract = false;
    }
}
