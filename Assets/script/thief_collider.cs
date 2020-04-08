using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thief_collider : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "s_bullet")   //스턴 총알을 맞을때
        {
            GameObject.FindGameObjectWithTag("thief").GetComponent<thief_move>().gasstun();
        }

        if (collision.collider.tag == "r_bullet")  //회복총알을 맞을때
        {
            GameObject.FindGameObjectWithTag("thief").GetComponent<thief_move>().recoverhit();
        }

        
    }
}
