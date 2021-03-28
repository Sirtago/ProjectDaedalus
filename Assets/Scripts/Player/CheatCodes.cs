using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatCodes : MonoBehaviour
{
    int step;
    PlayerHealth playerHealth;
    PlayerCurrency playerCurrency;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
        playerCurrency = GetComponent<PlayerCurrency>();
        step = 0;
    }

    // Update is called once per frame
    void Update()
    {
        switch (step)
        {
            case 0:
                if(Input.GetKeyDown(KeyCode.UpArrow))
                {
                    step++;
                }
                break;
            case 1:
                if(Input.GetKeyDown(KeyCode.UpArrow))
                {
                    step++;
                }
                break;
            case 2:
                if(Input.GetKeyDown(KeyCode.DownArrow))
                {
                    step++;
                }
                break;
            case 3:
                if(Input.GetKeyDown(KeyCode.DownArrow))
                {
                    step++;
                }
                break;
            case 4:
                if(Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    step++;
                }
                break;
            case 5:
                if(Input.GetKeyDown(KeyCode.RightArrow))
                {
                    step++;
                }
                break;
            case 6:
                if(Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    step++;
                }
                break;
            case 7:
                if(Input.GetKeyDown(KeyCode.RightArrow))
                {
                    step++;
                }
                break;
            case 8:
                if(Input.GetKeyDown(KeyCode.B))
                {
                    step++;
                }
                break;
            case 9:
                if(Input.GetKeyDown(KeyCode.A))
                {
                    playerCurrency.playerCurrency = 100000000;
                    playerHealth.health = 100000;
                }
                break;
            
            
        }
    }
}
