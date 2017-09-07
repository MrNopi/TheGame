using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField]
    private Transform target;
    private void Awake()
    {
        if (!target) target = FindObjectOfType<Moving>().transform;
    }
    private void Update()
    {
        Vector3 position = target.position; position.z = -10.0F; position.y += 3;
        transform.position = Vector3.Lerp(transform.position, position, 2.0f * Time.deltaTime);
    }
}
