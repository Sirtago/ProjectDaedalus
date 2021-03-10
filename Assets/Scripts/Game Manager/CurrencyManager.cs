using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyManager : MonoBehaviour
{
    //WIPE THIS ALL TOMMOROW AND MAKE DATAMANGER HOLD ALL PLAYER PREF ACCESS CODES.
    // Start is called before the first frame update
    public int globalCurrency;
    void Start()
    {
        print(PlayerPrefs.GetInt("SavedCurrency"));
    }

    // Update is called once per frame

    public void AddTotalCurrency(int value)
    {
        PlayerPrefs.SetInt("SavedCurrency", value);
        print(PlayerPrefs.GetInt("SavedCurrency"));

    }
    public void GiveTotalCurrency(int playerCurrency)
    {
        globalCurrency = PlayerPrefs.GetInt("SavedCurrency", 0);
        playerCurrency = globalCurrency;
    }
}
