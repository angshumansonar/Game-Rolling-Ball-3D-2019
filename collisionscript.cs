using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionscript : MonoBehaviour
{

    public GameObject iceball;
    public GameObject rockball;
    public GameObject metalball;
    public GameObject fireball;
    public GameObject regularball;

    void Start()
    {
        fireball.SetActive(false);
        iceball.SetActive(false);
        rockball.SetActive(false);
        metalball.SetActive(false);
        regularball.SetActive(true);
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag=="enemy")
        {
            Destroy(this.gameObject);
        }
        else if(col.gameObject.tag == "firepowertag")
        {
            fireball.SetActive(true);
            iceball.SetActive(false);
            rockball.SetActive(false);
            metalball.SetActive(false);
            regularball.SetActive(false);
            Destroy(GameObject.FindWithTag("firepowertag"));

        }
        else if(col.gameObject.tag == "icepowertag")
        {
            fireball.SetActive(false);
            iceball.SetActive(true);
            rockball.SetActive(false);
            metalball.SetActive(false);
            regularball.SetActive(false);
            Destroy(GameObject.FindWithTag("icepowertag"));
        }
        else if (col.gameObject.tag == "metalpowertag")
        {
            fireball.SetActive(false);
            iceball.SetActive(false);
            rockball.SetActive(false);
            metalball.SetActive(true);
            regularball.SetActive(false);
            Destroy(GameObject.FindWithTag("metalpowertag"));
        }
        else if (col.gameObject.tag == "rockpowertag")
        {
            fireball.SetActive(false);
            iceball.SetActive(false);
            rockball.SetActive(true);
            metalball.SetActive(false);
            regularball.SetActive(false);
            Destroy(GameObject.FindWithTag("rockpowertag"));
        }
    }


    
}
