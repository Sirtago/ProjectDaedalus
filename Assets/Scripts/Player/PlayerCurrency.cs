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
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
        GameManager.GetComponent<DataManager>().SaveAllData();
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            GameManager.GetComponent<CurrencyManager>().GiveTotalCurrency(playerCurrency);
        }
    }

    public void AddCurrency(int value)
    {
        playerCurrency = playerCurrency + value;
        currencyCount.text = playerCurrency.ToString();
    }
}
