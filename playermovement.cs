using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
  
    private Rigidbody rb;

    public bool jump;
    public bool isground;
    public float jumppower;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        jump = Input.GetButton("Jump");

        isground = Physics.Raycast(transform.position, Vector3.down, 1f);

        if(jump && isground)
        {
            rb.AddForce(Vector3.up * jumppower,ForceMode.Impulse);
        }
      
    }


    void FixedUpdate()
    {


        float movehr = Input.GetAxis("Horizontal");
        float movevr = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movehr*5f, 0f, movevr*5f);

        movement = Camera.main.transform.TransformDirection(movement);

        rb.AddForce(movement);

    }
}
