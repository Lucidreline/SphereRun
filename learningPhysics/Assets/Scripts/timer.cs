using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class timer : MonoBehaviour
{

    public Text timerText;
    private float startTime;
    private bool finished = false;
    private int whatScene;
    


    


    // Use this for initialization
    void Start()
    {
        startTime = Time.time;
        



    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        if (finished == true)
        {
            
   
            return;

        }
        else
        {

            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");
            string gameTime = minutes + ":" + seconds;

            timerText.text = gameTime;
        }

    }

    public void stopTimer()
    {
        finished = true;
        
    }

    

}