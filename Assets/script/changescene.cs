using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class changescene : MonoBehaviour
{
    public VideoPlayer video;
    public void ChangeFirstScene()
    {
        SceneManager.LoadScene("FirstScene");
    }
    public void ChangeDemoScene()
    {
        SceneManager.LoadScene("DemoScenes");
    }
    public void ChangeThirdScene()
    { 
        SceneManager.LoadScene("ThirdScene");
    }
}


