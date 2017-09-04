using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public static GameObject BuLLet;
    Vector3 pos;
    [SerializeField]
    public GameObject bullet;
    //blic static Vector3 pos;
    private void Start()
    {
        //pos = new Vector3(transform.position , transform.position.y, 0f);
        //bullet = FindObjectOfType<Bullet>();
    }
    IEnumerator shoot()
    {
        yield return new WaitForSeconds(3f);
    }
	public void Shoot()
    {
        Instantiate(bullet, transform.position + new Vector3(3f,1f,0f), Quaternion.identity);
    }
}
    