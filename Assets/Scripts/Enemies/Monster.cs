using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {
    private GameObject Hero;
    public Object bullet;
    private GameObject pose;
    Vector3 pos;
    private int hp;
    private int dmg;
    private void Awake()
    {
      //  bullet = Instantiate(Resources.Load<Object>(""));
        pos = new Vector3(transform.position.x * 8.3f, transform.position.y);
        Hero = GameObject.FindGameObjectWithTag("Player");
      //  this.gameObject.GetComponent<SpriteRenderer>().sprite = _class;   SWITCHING SPRITE
      // Ray2D ray = new Ray2D(this.transform.position, this.transform.forward);   RAY FOR "AIed" MONSTER
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
            {
            pose = (GameObject)Instantiate(Resources.Load("Bullet"), pos, Quaternion.identity);
            // transform.position = Vector3.MoveTowards(transform.position, pos, 6.0f * Time.deltaTime);
        }
 //       pose.transform.position = Vector3.MoveTowards(transform.position, pos, 6f * Time.deltaTime);
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
