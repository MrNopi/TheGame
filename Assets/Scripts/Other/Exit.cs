using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour {
    [SerializeField]
    private int Level_number;
    [SerializeField]
    private float exit_pos_y = 2.6f;
    private Image img;
    private Text text;
    Vector3 exit_position;
    Vector3 text_position;
    private float exit_pos_x = 0.61f;
    private void Start()
    {
                                        // Arrow Image
        img = GameObject.FindObjectOfType<Image>();
        exit_position = new Vector3(transform.position.x, transform.position.y + exit_pos_y, transform.position.z);
        img.transform.position = exit_position;
        img.enabled = false;
                                        // Text for interacting
        text = img.GetComponentInChildren<Text>();
       
        text.enabled = false;
    }
    private void Update()
    {
        text_position = new Vector3(transform.position.x + exit_pos_x, transform.position.y + 3.7f, transform.position.z);
        text.transform.position = text_position;
    }
    private void exit(int Level_number)
    {
        Application.LoadLevel(Level_number);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
                                        // Enter Interface start
        if (collision)
        {
            text.enabled = true;
            img.enabled = true;
        }
                                       // Exit by interacting
        if (collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            exit(Level_number);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
                                     // Enter interface end
        if (collision)
        {
            img.enabled = false;
            text.enabled = false;
        }
    }
}
