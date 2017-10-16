using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    bool attacking;
    [SerializeField]
    float rotation_angle;
    [SerializeField]
    float direction_x;
    [SerializeField]
    float direction_y;
    GameObject Character;
    CapsuleCollider2D coll;
    int counter;
    Vector3 Sword_position;
    // Use this for initialization
    void Start()
    {
        attacking = false;
        Character = GameObject.Find("Character");
        coll = gameObject.GetComponent<CapsuleCollider2D>();
        coll.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Attack();
        }
        Rot();
    }
    void Attack()
    {
        coll.enabled = true;
        Sword_position = new Vector3(Character.transform.position.x + direction_x, Character.transform.position.y + direction_y, 90);
        coll.transform.position = Sword_position;
        attacking = true;
        
    }
    void Rot() // 65
    {
        if (attacking && counter < Mathf.Abs(-65 / -rotation_angle) * 4)
        {
            coll.transform.Rotate(0, 0, -rotation_angle);
            counter++;
        }
        else
        {
            counter = 0;
            attacking = false;
            coll.enabled = false;
            coll.transform.rotation = new Quaternion(0, 0, -.9f, -.5f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Monster")
        {
            Destroy(collision.gameObject);
        }
    }
}
