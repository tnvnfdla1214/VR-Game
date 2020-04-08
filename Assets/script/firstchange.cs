using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class firstchange : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.F) || OVRInput.GetDown(OVRInput.Button.One) || OVRInput.GetDown(OVRInput.Button.Two) || OVRInput.GetDown(OVRInput.Button.Three) ||
                OVRInput.GetDown(OVRInput.Button.Four))
        {
            SceneManager.LoadScene("ThirdScene");
        }

    }
}
