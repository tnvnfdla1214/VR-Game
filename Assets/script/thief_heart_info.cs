using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class thief_heart_info : MonoBehaviour
{
    TextMeshProUGUI resourceText;
    public int life;

    void Start()
    {
        resourceText = GetComponent<TextMeshProUGUI>();
        life = GameObject.FindGameObjectWithTag("thief").GetComponent<thief_move>().heart;
    }

    void Update()
    {
        life = GameObject.FindGameObjectWithTag("thief").GetComponent<thief_move>().heart;
        resourceText.text = "LIFE:  " + life.ToString();
    }

}
