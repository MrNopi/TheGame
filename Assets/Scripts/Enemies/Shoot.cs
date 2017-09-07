using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : Bullet {
    // Use this for initialization
    private Bullet Bullet;
    void Start ()
    {
        Bullet = GameObject.FindObjectOfType<Bullet>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
        Shoot();
    }
}
