using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class thief_move : MonoBehaviourPunCallbacks
{
    public float moveSpeed;
    public float turnSpeed;
    private Animator thief_animator;
    private float h;
    private float v;
    public int stun;                //스턴총알 개수 파악
    public int recover;             //회복총알 개수 파악
    public Transform thief_firePos;       // 발사되는 위치
    public PhotonView PV;
    private Transform tr, tr2;
    private AudioSource _audio;
    public AudioClip fireSfx;
    private int run = Animator.StringToHash("run");
    private int shot = Animator.StringToHash("shot");
    private int damage = Animator.StringToHash("damage");
    public int heart = 5;

    void Start()
    {
        tr = GetComponent<Transform>();
        tr2 = GetComponent<Transform>();

        thief_animator = GetComponent<Animator>();
        _audio = this.gameObject.AddComponent<AudioSource>();
        moveSpeed = 5f;
        turnSpeed = 350f;
        stun = 5;
        recover = 0;
        heart = 5;
    }


    void Update()
    {
        if (!PV.IsMine) return;
        if (heart > 0)
        {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");

            if (h != 0 || v != 0) thief_animator.SetBool(run, true);
            else { thief_animator.SetBool(run, false); }
            //Move
            transform.Translate(0f, 0f, v * moveSpeed * Time.deltaTime);

            //Turn
            transform.Rotate(0f, h * turnSpeed * Time.deltaTime, 0f);
        }
    }

    void stun_unlock()
    {
        moveSpeed = 5f;
        turnSpeed = 350f;
    }
    public void hit()
    {
        heart--;
        thief_animator.SetTrigger("damage2");
    }
    public void gasstun()
    {
        moveSpeed = 0;
        turnSpeed = 0;
        Invoke("stun_unlock", 5);

    }
    public void stunplus()
    {
        stun++;
    }

    public void stunsub()
    {
        stun--;
    }

    public void recoverplus()
    {
        recover++;
    }

    public void recoverhit()
    {
        heart++;
    }
    
}
