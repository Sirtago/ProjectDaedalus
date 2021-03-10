using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
private GameObject player;
private CurrencyManager currencyManager;
void Update()
{
    player = GameObject.FindGameObjectWithTag("Player");
}
void Start()
{
    currencyManager = GetComponent<CurrencyManager>();
}
public void SaveAllData()
{
    //Save All Player Prefs
    GetComponent<CurrencyManager>().AddTotalCurrency(player.GetComponent<PlayerCurrency>().playerCurrency);
    PlayerPrefs.Save();
}
public void DeleteAllData()
{
    PlayerPrefs.DeleteAll();
}
}
