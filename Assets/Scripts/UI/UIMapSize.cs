using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMapSize : MonoBehaviour
{
    public Transform map;
    public Transform miniMap;
    private bool fullscreen;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            fullscreen = !fullscreen;
        }
        if(fullscreen)
        {
            cam.orthographicSize = 16f;
            transform.position = map.position;
            transform.localScale = map.localScale;
        }else
        {
            cam.orthographicSize = 8f;
            transform.position = miniMap.position;
            transform.localScale = miniMap.localScale;
        }
    }
}
