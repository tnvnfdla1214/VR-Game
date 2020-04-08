using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class thief_bullet_info : MonoBehaviour
{
    TextMeshProUGUI resourceText;
    public int bullet;

    void Start()
    {
        resourceText = GetComponent<TextMeshProUGUI>();
        bullet = GameObject.FindGameObjectWithTag("thief").GetComponent<thief_move>().stun;
    }


    void Update()
    {
        bullet = GameObject.FindGameObjectWithTag("thief").GetComponent<thief_move>().stun;
        resourceText.text = "BULLET:  " + bullet.ToString();
    }
}
