using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_manager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUi;

    public void CompleteLevel()
    {
        completeLevelUi.SetActive(true);
    }

    

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game over");
            Invoke("Restart", restartDelay);
        }
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
