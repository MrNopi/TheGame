using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HP : MonoBehaviour {
    private Text Health;
	// Use this for initialization
	void Start () {
        Health = GetComponentInParent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        Health.text = "Current Health is: " + Moving.currentHealth.ToString();
	}
}
