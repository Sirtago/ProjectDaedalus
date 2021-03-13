using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DDOL : MonoBehaviour
{
    static bool created = false;
        private void Awake()
        {
            if (!created) {
                    DontDestroyOnLoad (this.gameObject);
                    created = true;
                } else {
                    Destroy (this.gameObject);
                }
        }
        void Update()
        {
            if(SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(0))
            {
                Destroy(gameObject);
            }
        }
}



