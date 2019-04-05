using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endTRigger : MonoBehaviour {
    public game_manager gameManager;

    GameObject player;
    timer timerScript;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        timerScript = player.GetComponent<timer>();
    }

	void OnTriggerEnter(Collider col)
    {
        
        
        if(col.tag == "Player")
        {
            Debug.Log("Player finished");
            gameManager.CompleteLevel();
            timerScript.stopTimer();
            
        }
        
    }
}
