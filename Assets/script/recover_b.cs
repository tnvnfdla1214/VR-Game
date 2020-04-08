using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recover_b : MonoBehaviour
{
    public void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "thief_gun")
        {
            if (Input.GetKey(KeyCode.F) || OVRInput.GetDown(OVRInput.Button.One) || OVRInput.GetDown(OVRInput.Button.Two) || OVRInput.GetDown(OVRInput.Button.Three) ||
                OVRInput.GetDown(OVRInput.Button.Four))
            {
                Destroy(gameObject);
                GameObject.FindGameObjectWithTag("thief").GetComponent<thief_move>().recoverplus();
            }
        }
    }
}
