using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
    public Rigidbody rb;
    public int zForce;
    public int xForce;

    // Use this for initialization
    void Start()
    {

    }
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("d"))
        {
            rb.AddForce(xForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-xForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, zForce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -zForce * Time.deltaTime);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<game_manager>().EndGame();
        }
    }
}
