using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScript : MonoBehaviour {

	// Use this for initialization
	public void Start () {
        LoadInformation.LoadAllInformation();
        Debug.Log(gameInformation.PlayerName);
        Debug.Log("Intellect: " +gameInformation.Intellect);
        Debug.Log("Strength: "+gameInformation.Strength);
        Debug.Log("Agility: "+gameInformation.Agility);
        Application.LoadLevel("Level_1");
        	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
