using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasurebox : MonoBehaviour
{
   void Update()
    {
        Application.Quit();
    }
   public void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            if (Input.GetKey(KeyCode.F))
            {
                Update();
            }
        }
    }

}
