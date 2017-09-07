using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {
    private GameObject Hero;
    public GameObject bullet;
    private GameObject pose;
    private int hp;
    private int dmg;
    private void Awake()
    {
        Hero = GameObject.FindGameObjectWithTag("Player");
     //   Debug.Log(gameInformation.PlayerClass);
      //  this.gameObject.GetComponent<SpriteRenderer>().sprite = _class;   SWITCHING SPRITE
       // Ray2D ray = new Ray2D(this.transform.position, this.transform.forward);   RAY FOR "AIed" MONSTER
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            {
            Vector3 pos = new Vector3(transform.position.x * Time.deltaTime, transform.position.y, transform.position.z);
            pose = Instantiate(bullet, pos, Quaternion.identity);
            for (float i = 0; i < 1; i += 0.1f)
            pose.transform.position = transform.position * i ;
            // transform.position = Vector3.MoveTowards(transform.position, pos, 6.0f * Time.deltaTime);
        }

    }
    private void follow()
    {
       
        // if (Radius)
        {
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
       /* if (collider.gameObject.tag == obstacle)
        {
            
        }*/
        if (collider.gameObject == Hero) {
            Debug.Log("Dead");
            Die();
            Debug.Log(Moving.Xp);
        }
    }

    public  void Die() {
        Destroy(gameObject);
        Moving.Xp += 30;
    }
}
