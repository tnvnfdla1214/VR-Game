using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class hunter_move : MonoBehaviourPunCallbacks
{
    public float moveSpeed;
    public float turnSpeed;
    private Animator Hunter_animator;
    private float h;
    private float v;
    public int stun;                //스턴총알 개수 파악
    public PhotonView PV;
    private Transform tr, tr2;
    public AudioClip fireSfx;
    private AudioSource _audio;
    private int run = Animator.StringToHash("run");
    private int shot = Animator.StringToHash("shot");
    private int damage = Animator.StringToHash("damage");

    void Start()
    {
        tr = GetComponent<Transform>();
        tr2 = GetComponent<Transform>();
        _audio = this.gameObject.AddComponent<AudioSource>();
        Hunter_animator = GetComponent<Animator>();

        moveSpeed = 6.5f;
        turnSpeed = 350f;
        stun = 300;
    }

    void Update()
    {
        if (!PV.IsMine) return;

            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
            //Move
            if (h != 0 || v != 0) Hunter_animator.SetBool(run, true);
            else { Hunter_animator.SetBool(run, false); }
            transform.Translate(0f, 0f, v * moveSpeed * Time.deltaTime);

            //Turn
            transform.Rotate(0f, h * turnSpeed * Time.deltaTime, 0f);

    }


    public void hit_stun()
    {
        moveSpeed = 0;
        turnSpeed = 0;
        Invoke("stun_unlock", 5);

    }

    void stun_unlock()
    {
        moveSpeed = 5f;
        turnSpeed = 540f;
    }

    public void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "s_bullet")
        {
            moveSpeed = 0;
            turnSpeed = 0;
            Invoke("stun_unlock", 5);
            Hunter_animator.SetTrigger("damage2");

        }
    }
}
