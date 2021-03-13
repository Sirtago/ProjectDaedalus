using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DDOL : MonoBehaviour
{

        private void Awake()
        {
            DontDestroyOnLoad(transform.gameObject);
        }
        void Update()
        {
            if(SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(0))
            {
                Destroy(gameObject);
            }
        }
}



