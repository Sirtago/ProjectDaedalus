using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public GameObject Options;
    public GameObject Main;
    // Start is called before the first frame update
  public void Back()
  {
      Main.SetActive(true);
      Options.SetActive(false);     
  }
}
