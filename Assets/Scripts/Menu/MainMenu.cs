using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject Main;
    public GameObject OptionsM;
    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
        Time.timeScale =1;
    }
    public void Options()
    {
        OptionsM.SetActive(true);
        Main.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("QUIT!");
    }
}
