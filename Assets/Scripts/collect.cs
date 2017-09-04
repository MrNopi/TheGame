using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Moving.score += 13.0f;
        Destroy(gameObject);
        Debug.Log(Moving.score);
    }
}
