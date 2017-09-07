using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovalableMonster : MonoBehaviour {
    private Vector3 pos;
    [SerializeField]
    private float speed = 1.7f;
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        pos = new Vector3(transform.position.x + Time.deltaTime * speed, -2, 0);
        this.transform.position = pos;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Environment")
        {
            speed *= -1;
        }
        else if (collision.gameObject.tag == "Player")
        {
            Moving.currentHealth -= 30;
            Debug.Log(Moving.currentHealth);
        }
    }
}
