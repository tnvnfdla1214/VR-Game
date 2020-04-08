using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float force = 2000.0f;
    public GameObject effect;
 
    void Update()
    {
        transform.Translate(Vector3.forward * 1f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(Instantiate(effect, this.transform.position, Quaternion.identity), 0.5f);
        Destroy(gameObject);
    }
}
