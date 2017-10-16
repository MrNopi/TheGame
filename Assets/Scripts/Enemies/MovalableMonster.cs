using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovalableMonster : MonoBehaviour {
    private bool rightface = false;
    [SerializeField]
    private float follow_dist = 2.2f;
    private Vector3 Movepos;
    private Vector2 start;
    private Vector2 dir;
    private GameObject player;
    private float distance = 5f;
    private float navig;
    [SerializeField]
    private float speed = 1.7f;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        start = new Vector2(this.transform.position.x, this.transform.position.y);
        dir = new Vector2(player.transform.position.x, player.transform.position.y);
        Debug.Log(transform.position.x);
        Debug.Log(player.transform.position.x);
    }

    // Update is called once per frame
    void Update() {
        navig = Vector3.Distance(new Vector3(transform.position.x, transform.position.y, transform.position.z), new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z)) - 5;

        if (Right() && (navig < 5f && navig > follow_dist))
        {
            speed = -Mathf.Abs(speed);
        }
        else if (!Right() && (navig < 5f && navig > follow_dist))
        {
            speed = Mathf.Abs(speed);
        }
   /*     if (Right() && 
            (speed > 0) || 
            (!Right() && 
            (speed < 0))) // if character is in range 
        Debug.Log(navig = Vector3.Distance(new Vector3(transform.position.x, transform.position.y, transform.position.z), new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z)) - 5);
        //Debug.DrawLine(new Vector3(transform.position.x, transform.position.y, transform.position.z), new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z), Color.red);
          if (navig < 1.3f)
            transform.position = player.transform.position;
        
           if (navig < 1)
        {
            transform.position = player.transform.position;
        }
        if (navig < 5)
        {
            transform.position = new Vector3(navig /= 1.2f - speed, transform.position.y);
        }
     */ 
            //Moving from side to side
            Movepos = new Vector3(transform.position.x + Time.deltaTime * -speed, -2, 0);
            this.transform.position = Movepos;
       
    }
                                                    //Changing trajectory, whenever face the environment
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
    private bool Right() // is character on right
    {
        if (transform.position.x > player.transform.position.x)
        {
            return rightface = false;
        }
        else //(transform.position.x < player.transform.position.x)
        {
            return rightface = true;
        }
    }
}
