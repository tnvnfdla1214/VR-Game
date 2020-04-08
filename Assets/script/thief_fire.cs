using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class thief_fire : MonoBehaviourPunCallbacks
{
    public Transform firePos;       // 발사되는 위치
    public GameObject s_bullet;       // 스턴 발사할 총알
    public int stun;                //스턴총알 개수 파악
    public int heart;             //회복총알 개수 파악
    public PhotonView PV;
    private AudioSource _audio;
    public AudioClip fireSfx;

    void Start()
    {
        stun = GameObject.FindGameObjectWithTag("thief").GetComponent<thief_move>().stun;
        heart = GameObject.FindGameObjectWithTag("thief").GetComponent<thief_move>().heart;
    }

    // Update is called once per frame
    void Update()
    {
        stun = GameObject.FindGameObjectWithTag("thief").GetComponent<thief_move>().stun;
        heart = GameObject.FindGameObjectWithTag("thief").GetComponent<thief_move>().heart;
        if (stun > 0&& heart > 0)
        {
            if (Input.GetKey(KeyCode.T) || OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
            {
                int actorNumver = photonView.Owner.ActorNumber;
                photonView.RPC("Fire", RpcTarget.Others, actorNumver);
                Fire(actorNumver);
                GameObject.FindGameObjectWithTag("thief").GetComponent<thief_move>().stunsub();
            }

        }

    }
    [PunRPC]  //RPC 이벤트 발생시 정보를 보내는
    void Fire(int number)
    {
        _audio.PlayOneShot(fireSfx, 0.8f);
        GameObject obj = Instantiate(s_bullet, firePos.position, firePos.rotation);
        obj.GetComponent<bullet>().actorNumber = number;
    }


}
