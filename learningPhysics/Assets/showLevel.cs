using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class showLevel : MonoBehaviour {
    public TextMeshPro levelText;
    int currentLevel;

	// Use this for initialization
	void Start () {
        currentLevel = (SceneManager.GetActiveScene().buildIndex);
        levelText.text = "Level " + currentLevel.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
