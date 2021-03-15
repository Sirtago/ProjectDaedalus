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
        Time.timeScale =1;
        StartCoroutine(LoadAsync());
    }
    IEnumerator LoadAsync()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(1);
        while(!operation.isDone)
        {
            Debug.Log(operation.progress);
            yield return null;
        }
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
