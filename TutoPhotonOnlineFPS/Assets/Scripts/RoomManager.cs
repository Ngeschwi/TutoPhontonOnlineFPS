using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class RoomManager : MonoBehaviourPunCallbacks
{
    private void Start()
    {
        Debug.Log("Connecting to server...");
        
        PhotonNetwork.ConnectUsingSettings();
    }
    
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to server!");
        
        base.OnConnectedToMaster();
        
        PhotonNetwork.JoinLobby();
    }
}
