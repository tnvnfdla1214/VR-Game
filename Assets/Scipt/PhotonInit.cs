using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonInit : MonoBehaviourPunCallbacks {

    private string gameVersion = "1.0";
    public string userId = "YouRang";
    public byte maxPlayer = 20;


    void Awake()
    {
        //Screen.SetResolution(960, 540, false);
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    void Start()
    {
        PhotonNetwork.GameVersion = this.gameVersion;
        PhotonNetwork.NickName = userId;

        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connect To Master");
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("Failed Join room !!!");
        PhotonNetwork.CreateRoom(null, new RoomOptions { MaxPlayers = this.maxPlayer });
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined Room !!!");
        Createchracter();
       
    }

    void Createchracter()
    {
        Transform[] points = GameObject.Find("PointGroup")
                                .GetComponentsInChildren<Transform>();

        int idx = Random.Range(1, points.Length);

        GameObject player = PhotonNetwork.Instantiate("hunter"
                                , points[idx].position
                                , Quaternion.identity);

        // GameObject player = PhotonNetwork.Instantiate("Hunter", new Vector3(3,1,2), Quaternion.identity); 
        GameObject camera = GameObject.Find("Huntercamera");
        GameObject firepos = GameObject.Find("FirePos(hunter)");
        //  GameObject tmp = GameObject.FindWithTag("Rcontrol");

        //GameObject pos = GameObject.Find("firePos");
        camera.transform.SetParent(player.transform);
        //camera.transform.position = player.transform.position;
        Vector3 t,t2;
        t = player.transform.position;
        t.x += 0;
        t.y += 2;
        t.z += 2;
        camera.transform.position = t;
        //0.3 2.8
        Transform tr4;
        firepos.transform.SetParent(camera.transform.Find("TrackingSpace/RightHandAnchor/Weapon/musketoon_short"));
        t2 = camera.transform.Find("TrackingSpace/RightHandAnchor/Weapon/musketoon_short").position;
        //TrackingSpace/RightHandAnchor/thiefgun
        t2.z += 2.5f;
        firepos.transform.position = t2;

        //firepos.transform.SetParent(camera.transform);

        //player.GetComponent<FireCannon>().firePos = firepos.transform;
        //FireCannon fc = player.GetComponent<FireCannon>();
        //fc.firePos = pos.transform;
        // GameObject FC = GetComponent<FireCannon>
        //player.AddComponent<FireCannon>.Firepos
    }
}


