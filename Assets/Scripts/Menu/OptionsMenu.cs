using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public GameObject Options;
    public GameObject Main;
    void Start()
    {
      Screen.fullScreen = true;
    }
  public void Back()
  {
      Main.SetActive(true);
      Options.SetActive(false);     
  }
  public void SetFullScreen(bool isFullscreen)
  {
    Screen.fullScreen = isFullscreen;
  }
}
