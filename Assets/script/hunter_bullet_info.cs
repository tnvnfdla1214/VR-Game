using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hunter_bullet_info : MonoBehaviour
{
    TextMeshProUGUI resourceText;
    public int bullet;

    void Start()
    {
        resourceText = GetComponent<TextMeshProUGUI>();
        bullet = GameObject.FindGameObjectWithTag("Player").GetComponent<hunter_move>().stun;
    }

    // Update is called once per frame
    void Update()
    {
        bullet = GameObject.FindGameObjectWithTag("Player").GetComponent<hunter_move>().stun;
        resourceText.text = "BULLET:  " + bullet.ToString();
    }
}
