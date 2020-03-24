using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float Rotspeed;

    void Start()
    {
        offset = transform.position - target.transform.position;
    }
     void LateUpdate()
    {
        Quaternion camturnangle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * Rotspeed, Vector3.up);
        offset = camturnangle * offset;

        transform.position = target.transform.position+offset;
        transform.LookAt(target);
    }
}
