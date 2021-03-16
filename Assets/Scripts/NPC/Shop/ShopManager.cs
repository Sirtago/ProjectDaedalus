using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public GameObject shopkeeper;
    public GameObject shopMenu;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
       if(shopkeeper == null )
        {
            shopkeeper = GameObject.FindGameObjectWithTag("Shopkeeper");
        }
        if(player == null )
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        if(shopMenu == null)
        {
            shopMenu = GameObject.Find("Shop");
            shopMenu.SetActive(false);
        }    
    }
    public void BuyFireRate(int price)
    {
        if(player.GetComponent<PlayerCurrency>().playerCurrency >= price)
        {
            player.GetComponent<PlayerCurrency>().LoseCurrency(price);
            player.GetComponentInChildren<ShootingSystem>().basicFireRate = player.GetComponentInChildren<ShootingSystem>().basicFireRate - 0.25f;
        }
        //Up Firerate
    }
    public void BuyArmor(int price)
    {
        if(player.GetComponent<PlayerCurrency>().playerCurrency >= price)
        {
            player.GetComponent<PlayerCurrency>().LoseCurrency(price);
            player.GetComponent<PlayerHealth>().health = player.GetComponent<PlayerHealth>().health + 1;
        }
    }
    public void BuySave(int price)
    {
        if(player.GetComponent<PlayerCurrency>().playerCurrency >= price)
        {
            player.GetComponent<PlayerCurrency>().LoseCurrency(price);
        }
    }
    public void Back()
    {
        shopMenu.SetActive(false);
    }
    public void OpenShop()
    {

        //Open Shop Menu
        shopMenu.SetActive(true);
        Debug.Log("Windows Open");
    
    }
}
