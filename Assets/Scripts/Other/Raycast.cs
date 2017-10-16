using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {

    public float RaycastPosY;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        float Distance;
        Vector3 forward = new Vector3(transform.position.x * -10f, transform.position.y + RaycastPosY);
        Debug.DrawRay(transform.position, forward, Color.red);
        if (Physics.Raycast(transform.position, forward, out hit))
        {
            Distance = hit.distance;
            Debug.Log(Distance + " " + hit.collider.gameObject.name);
        }

    }
}
