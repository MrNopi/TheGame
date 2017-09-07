using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_test : MonoBehaviour {
    private GameObject Box;
	// Use this for initialization
	void Start () {
        Box = GameObject.Find("Test");
        Box.AddComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
