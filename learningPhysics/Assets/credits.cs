using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class credits : MonoBehaviour {

    public Text scoreList;
    

    


    void Start()
    {
        
    }

	public void Quit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
