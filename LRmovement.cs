using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRmovement : MonoBehaviour
{
    public float speed;
    public float length;

    void Update()
    {
        Vector3 pos = transform.position;
        float newZ = Mathf.Sin(Time.time * speed) * length + pos.z;
        transform.position = new Vector3(pos.x, pos.y, newZ);
    }

}
