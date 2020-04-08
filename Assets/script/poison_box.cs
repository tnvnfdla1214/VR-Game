using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poison_box : MonoBehaviour
{
    public GameObject gas;
    public Transform gasPos;
    private AudioSource _audio;
    public AudioClip fireSfx;

    private void OnCollisionStay(Collision collision)
    {
        _audio = this.gameObject.AddComponent<AudioSource>();
        if (collision.collider.tag == "thief_gun")
        {
            if (Input.GetKey(KeyCode.F) || OVRInput.GetDown(OVRInput.Button.One) || OVRInput.GetDown(OVRInput.Button.Two) || OVRInput.GetDown(OVRInput.Button.Three) ||
                OVRInput.GetDown(OVRInput.Button.Four))
            {
                _audio = this.gameObject.AddComponent<AudioSource>();
                _audio.PlayOneShot(fireSfx, 0.8f);
                Destroy(gameObject);
                Destroy(Instantiate(gas, gasPos.transform.position, gasPos.transform.rotation), 5.0f);
                GameObject.FindGameObjectWithTag("thief").GetComponent<thief_move>().gasstun();
            }
        }
    }
}
