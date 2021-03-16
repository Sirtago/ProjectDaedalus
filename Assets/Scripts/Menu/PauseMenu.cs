using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    bool isPaused;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            pauseMenu.SetActive(true);
            isPaused = true;
            Time.timeScale = 0;
            FindObjectOfType<ShootingSystem>().canShootBasic = false;
            Debug.Log("PAUSED");
        }
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
        FindObjectOfType<ShootingSystem>().canShootBasic = true;
        Time.timeScale = 1;

    }
    public void Quit()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
