using System;
using System.Collections;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using UnityEngine;

public class Controller_PhotonSetting : Photon.MonoBehaviour
{


    void Start()
    {
        PhotonNetwork.ConnectUsingSettings("ver1.0");
    }


    void Update()
    {
        //測試用
        if (PhotonNetwork.insideLobby)
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                CheckRoom("135");
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                PhotonNetwork.CreateRoom(UnityEngine.Random.Range(1000,9999).ToString());
            }
        }

    }






    //進入遊戲房間
    public void EnterRoom(string RoomCode)
    {
        if (!PhotonNetwork.inRoom)
            PhotonNetwork.JoinRoom(RoomCode);

    }


    //檢查遊戲房間是否存在
    public void CheckRoom(string RoomCode)
    {
        RoomInfo[] rooms = PhotonNetwork.GetRoomList();
        if (rooms.Length == 0)
        {
            print("目前沒半個房間");
            return;
        }

        for (int i = 0; i < rooms.Length; i++)
        {
            if (RoomCode == rooms[i].Name)
            {
                EnterRoom(RoomCode);
                print("房間存在");
            }
            else
            {
                print("房間不存在");
            }
        }
    }


#region
    public void OnConnectedToPhoton()
    {
        print("成功連接上Photon");
        //throw new NotImplementedException();
    }

    public void OnLeftRoom()
    {
        print("離開房間");
        //throw new NotImplementedException();
    }

    public void OnPhotonCreateRoomFailed(object[] codeAndMsg)
    {
        print("創建房間失敗");
        //throw new NotImplementedException();
    }

    public void OnPhotonJoinRoomFailed(object[] codeAndMsg)
    {
        print("加入房間失敗");
        //throw new NotImplementedException();
    }

    public void OnCreatedRoom()
    {
        print("創建房間");
        //throw new NotImplementedException();
    }

    public void OnJoinedLobby()
    {
        print("成功進入大廳");
        //throw new NotImplementedException();
    }

    public void OnLeftLobby()
    {
        print("離開大廳");
        //throw new NotImplementedException();
    }

    public void OnFailedToConnectToPhoton(DisconnectCause cause)
    {
        print("連接Photon失敗");
        //throw new NotImplementedException();
    }

    public void OnConnectionFail(DisconnectCause cause)
    {
        print("連接失敗");
        //throw new NotImplementedException();
    }

    public void OnDisconnectedFromPhoton()
    {
        print("與Photon斷線");
        throw new NotImplementedException();
    }
    /*
    public void OnReceivedRoomListUpdate()
    {
        throw new NotImplementedException();
    }
    */
    public void OnJoinedRoom()
    {
        //throw new NotImplementedException();
        print("已加入 "+PhotonNetwork.room.Name+" 房間");
    }
    
    public void OnPhotonPlayerConnected(PhotonPlayer newPlayer)
    {
        print("有玩家加入囉");
        //throw new NotImplementedException();
    }
    /*
    public void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer)
    {
        throw new NotImplementedException();
    }

    public void OnPhotonRandomJoinFailed(object[] codeAndMsg)
    {
        throw new NotImplementedException();
    }

    public void OnConnectedToMaster()
    {
        throw new NotImplementedException();
    }

    public void OnPhotonMaxCccuReached()
    {
        throw new NotImplementedException();
    }

    public void OnPhotonCustomRoomPropertiesChanged(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
    {
        throw new NotImplementedException();
    }

    public void OnPhotonPlayerPropertiesChanged(object[] playerAndUpdatedProps)
    {
        throw new NotImplementedException();
    }

    public void OnUpdatedFriendList()
    {
        throw new NotImplementedException();
    }

    public void OnCustomAuthenticationFailed(string debugMessage)
    {
        throw new NotImplementedException();
    }

    public void OnCustomAuthenticationResponse(Dictionary<string, object> data)
    {
        throw new NotImplementedException();
    }

    public void OnWebRpcResponse(OperationResponse response)
    {
        throw new NotImplementedException();
    }

    public void OnOwnershipRequest(object[] viewAndPlayer)
    {
        throw new NotImplementedException();
    }

    public void OnLobbyStatisticsUpdate()
    {
        throw new NotImplementedException();
    }

    public void OnPhotonPlayerActivityChanged(PhotonPlayer otherPlayer)
    {
        throw new NotImplementedException();
    }

    public void OnOwnershipTransfered(object[] viewAndPlayers)
    {
        throw new NotImplementedException();
    }
    */
#endregion



}
