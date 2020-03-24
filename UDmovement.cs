using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UDmovement : MonoBehaviour
{
    public float speed;
    public float height;

    void Update()
    {
        Vector3 pos = transform.position;
        float newY = Mathf.Sin(Time.time * speed) * height + pos.y;
        transform.position = new Vector3(pos.x, newY, pos.z);
    }
}
