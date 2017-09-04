using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {
    public GameObject Hero;
    private int hp;
    private int dmg;
    private void Start()
    {
        Debug.Log(gameInformation.PlayerClass);
      //  this.gameObject.GetComponent<SpriteRenderer>().sprite = _class;   SWITCHING SPRITE
       // Ray2D ray = new Ray2D(this.transform.position, this.transform.forward);   RAY FOR "AIed" MONSTER
    }
    private void Update()
    {
        follow();
        Vector3 pos = transform.right;
     // transform.position = Vector3.MoveTowards(transform.position, pos, 6.0f * Time.deltaTime);
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
