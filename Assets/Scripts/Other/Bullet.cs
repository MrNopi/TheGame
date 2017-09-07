using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    Vector3 pos;
    private GameObject bull;
    private GameObject bullet;
    Rigidbody2D rb;
    private void Start()
    {
        rb = bull.GetComponent<Rigidbody2D>();
        //pos = new Vector3(transform.position , transform.position.y, 0f);
        //bullet = FindObjectOfType<Bullet>();
    }
    private void Update()
    {
        
    }
    IEnumerator shoot()
    {
        Vector3 pos = new Vector3(transform.position.x * Time.deltaTime, transform.position.z);
        yield return new WaitForSeconds(3f);
    }
	public void Shoot()
    {
        pos = new Vector3(transform.position.x * Time.deltaTime * 1.7f, 0f);
        Debug.Log("asd");
       bull = Instantiate(bullet, pos, Quaternion.identity);
        rb.AddForce(new Vector2(3f, 0f));
    }
}
    