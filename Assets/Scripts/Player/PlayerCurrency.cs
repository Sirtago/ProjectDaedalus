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
        GameManager.GetComponent<DataManager>().LoadAllData();
        currencyCount.text = playerCurrency.ToString();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            GameManager.GetComponent<DataManager>().SaveAllData();
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            GameManager.GetComponent<DataManager>().LoadAllData();
        }
       if(Input.GetKeyDown(KeyCode.L))
        {
            GameManager.GetComponent<DataManager>().DeleteAllData();
        }
    }

    public void AddCurrency(int value)
    {
        playerCurrency = playerCurrency + value;
        currencyCount.text = playerCurrency.ToString();
    }
}
