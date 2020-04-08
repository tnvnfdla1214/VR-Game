using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hunter_collider : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "s_bullet")
        {
            GameObject.FindGameObjectWithTag("hunter").GetComponent<hunter_move>().hit_stun();
        }
    }
}
