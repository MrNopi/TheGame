using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest : MonoBehaviour {
    private Object[] arr;
	// Use this for initialization
	void Start () {
        Object[] arr = Resources.LoadAll("Items");
        //arr = new Object[3];
        /*for (int i = 0; i != arr.Length - 1; i++)
        {
            arr[i] = arr[Random.Range(0, arr.Length)];
        }*/
        Debug.Log(arr.Length);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(this.gameObject);
            for (int j = 0; j != Random.Range(0,4);j++)
            {
                int rnd = Random.Range(0, arr.Length);
                Debug.Log(arr[rnd].name);
                Instantiate(arr[rnd], new Vector3(transform.position.x + (j * 5f), transform.position.y), Quaternion.identity);
            }
        }
    }
}
