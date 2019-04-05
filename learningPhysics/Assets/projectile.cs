using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour {
    public Rigidbody RB;
    public int throwForce;
    public float delay;
    // Use this for initialization
    
    void Start() {
        Invoke("ThrowProjectile", delay);
    }
    public void ThrowProjectile(){
        RB.AddForce(-throwForce * Time.deltaTime, 2000 * Time.deltaTime, 0);
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
