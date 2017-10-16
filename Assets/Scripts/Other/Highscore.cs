using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Highscore : MonoBehaviour {
    private Text score;
    private Text Health;
    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(transform.gameObject);
        score = GetComponentInChildren<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        score.text = "Score is: " + Moving.score.ToString();
	}
}
