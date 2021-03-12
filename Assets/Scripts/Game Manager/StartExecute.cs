using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartExecute : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
    SceneManager.sceneLoaded += OnSceneLoaded;

    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);
        Debug.Log(mode);
        if(GameObject.FindGameObjectWithTag("Player") != null){GetComponent<DataManager>().LoadAllData();}
        else{return;}
    }
    void Awake()
    {
    GetComponent<DataManager>().LoadAllData();   
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            SceneManager.LoadScene("Level 1");
        }
    }
}
