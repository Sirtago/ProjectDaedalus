using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class DataManager : MonoBehaviour
{
private GameObject player;
public int globalCurrency;

void Update()
{
    player = GameObject.FindGameObjectWithTag("Player");
}

public void SaveAllData()
{
    //SAVE ALL PLAYER PREFS
    globalCurrency = player.GetComponent<PlayerCurrency>().playerCurrency;
    PlayerPrefs.SetInt("Currency", globalCurrency);
    PlayerPrefs.Save();
    print("Total Currency: " + PlayerPrefs.GetInt("Currency"));
}

public void LoadAllData()
{
    //LOAD ALL PLAYER PREFS
    globalCurrency = PlayerPrefs.GetInt("Currency");
    player.GetComponent<PlayerCurrency>().playerCurrency = globalCurrency;
    print("Money Load: " + globalCurrency);
}
public void DeleteAllData()
{
    //DELETE ALL PLAYER PREFS
    PlayerPrefs.DeleteAll();
}
}
