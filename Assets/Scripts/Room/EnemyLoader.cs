using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLoader : MonoBehaviour
{
    private CameraSnap camSnap;
    public List<GameObject> enemyGameObject;
    public LayerMask enemyMask;
    // Start is called before the first frame update
    void Start()
    {
        camSnap = GetComponent<CameraSnap>();
    }
 
    // Update is called once per frame
    void Update()
    {
        if(camSnap.isSnapped)
        {
            foreach(GameObject enemy in enemyGameObject)
            {
                if(enemy != null)
                {
                enemy.SetActive(true);
                }
            }
        }
        if(!camSnap.isSnapped)
        {
            foreach(GameObject enemy in enemyGameObject)
            {
                if(enemy != null)
                {
                enemy.SetActive(false);
                }
            }
        }
    }
}
