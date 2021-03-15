using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour
{
  public float loadingTime;
    void Update()
    {
        if(loadingTime <= 0)
        {
            Destroy(gameObject);
        }else{loadingTime -= 1 * Time.deltaTime;}
    }
}
