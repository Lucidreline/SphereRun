using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

 

    void OnCollisionEnter(Collision crashInfo)
    {
        
        if (crashInfo.collider.tag == "obstacle")
        {

            

        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
