using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour
{
private GameObject player;
public int globalCurrency;
public float globalFireRate;
void Update()

{
    if(player = null)
    {
    player = GameObject.FindGameObjectWithTag("Player");
    }
}

public void SaveAllData()
{
    //SAVE ALL PLAYER PREFS
    globalCurrency = player.GetComponent<PlayerCurrency>().playerCurrency;
    globalFireRate = player.GetComponentInChildren<ShootingSystem>().basicFireRate;
    PlayerPrefs.SetInt("Currency", globalCurrency);
    PlayerPrefs.SetFloat("FireRate", globalFireRate);
    PlayerPrefs.Save();
}

public void LoadAllData()
{
    //LOAD ALL PLAYER PREFS
    globalCurrency = PlayerPrefs.GetInt("Currency");
    globalFireRate = PlayerPrefs.GetFloat("FireRate");
    player.GetComponent<PlayerCurrency>().playerCurrency = globalCurrency;
    player.GetComponentInChildren<ShootingSystem>().basicFireRate = globalFireRate;
    print("Money Load: " + globalCurrency);
    print("Fire Rate: " + globalFireRate);
}
public void DeleteAllData()
{
    //DELETE ALL PLAYER PREFS
    PlayerPrefs.DeleteAll();
}
}
