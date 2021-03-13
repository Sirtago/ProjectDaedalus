using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCurrency : MonoBehaviour
{
    public int playerCurrency;
    private GameObject GameManager;
    public TMP_Text currencyCount;

    void Start()
    {
        GameManager = GameObject.FindGameObjectWithTag("Game Manager");
        currencyCount.text = playerCurrency.ToString();
    }
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.L))
        {
            GameManager.GetComponent<DataManager>().DeleteAllData();
            Debug.Log("DATA DELETD");
        }
    }

    public void LoseCurrency(int price)
    {
        playerCurrency = playerCurrency -= price;
        currencyCount.text = playerCurrency.ToString();
    }
    public void AddCurrency(int value)
    {
        playerCurrency = playerCurrency + value;
        currencyCount.text = playerCurrency.ToString();
    }
}
