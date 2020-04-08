using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour
{
  public void ChangeFirstScene()
    {
        SceneManager.LoadScene("Demostart");
    }
    public void ChangeSecondScene()
    {
        SceneManager.LoadScene("DemoScenes");
    }
}
