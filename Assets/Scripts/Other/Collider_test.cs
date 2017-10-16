using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_test : MonoBehaviour {
    BoxCollider2D Box;
    [SerializeField]
    private float Size_x;
    [SerializeField]
    private float Size_y;
	// Use this for initialization
	void Start () {
        Box = this.gameObject.AddComponent<BoxCollider2D>();
        Box.enabled = true;
	}

    // Update is called once per frame
    void Update ()
    {
        if (!Box.enabled && Input.GetKeyDown(KeyCode.I))
        {
            Box.enabled = true;
        }
        else if (Box.enabled && Input.GetKeyDown(KeyCode.I))
        {
            Box.enabled = false;
        }
        Box.size = new Vector2 (Size_x, Size_y);
    }
}
