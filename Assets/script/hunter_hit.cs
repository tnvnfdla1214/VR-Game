using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class hunter_hit : MonoBehaviour
{
    public GameObject hunter;
    public GameObject thief;
 
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "thief")
        {
            GameObject.FindGameObjectWithTag("hunter").GetComponent<hunter_move>().hit_stun();
            GameObject.FindGameObjectWithTag("thief").GetComponent<thief_move>().hit();


        }
    }
}
