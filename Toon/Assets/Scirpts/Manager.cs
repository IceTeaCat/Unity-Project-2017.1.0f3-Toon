using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public float GameTime=0;

    enum State
    {
        S_MainMenu,
        S_GameRoom,
        S_WaitForPlayer,
        S_ReadyToPlay,
        S_RandomCharacter,
        S_StartGame,
        S_PauseGame,
        S_GameOver,
        S_WaitToWinner,
        S_Awards,
        S_RoundEnd,        
    }
	


	void Start () {
		
	}
	
	
	void Update () {
		
	}
}
