using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller_Manager : MonoBehaviour {

    public Controller_PhotonSetting CP;


    //RoomPanel
    public Text InvitationCode;




    void Start () {
		
	}
	
	
	void Update () {
		
	}


    //輸入邀請瑪確認按鈕
    public void EnterInvitationCode()
    {
        print(InvitationCode.text);
        CP.CheckRoom(InvitationCode.text);
    }


}
