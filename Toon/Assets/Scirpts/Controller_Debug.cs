using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller_Debug : Photon.MonoBehaviour
{


    void Start()
    {

    }


    void Update()
    {
        GetComponent<Text>().text = PhotonNetwork.connectionStateDetailed.ToString();
    }
}
