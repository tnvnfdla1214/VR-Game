using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poisonGas : MonoBehaviour
{
    public GameObject gas;
    public Transform gasPos;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            if (Input.GetKey(KeyCode.F))
            {
                Destroy(gameObject);
                Destroy(Instantiate(gas, gasPos.transform.position, gasPos.transform.rotation), 3.0f);
            }
        }
    }
}
