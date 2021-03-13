using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopkeeperInteract : MonoBehaviour
{
    ShopManager shop;
    bool canInteract;
    void Start()
    {
        shop = GameObject.FindGameObjectWithTag("Game Manager").GetComponent<ShopManager>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && canInteract)
        {
        shop.OpenShop();
        Debug.Log("Windows Open");
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == ("Player"))
        {
            canInteract = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
        canInteract = false;
        }
    }
}
