using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dobradica2 : MonoBehaviour
{

    Rigidbody dobraRigidbody;

    Vector3 force;

    // Start is called before the first frame update
    void Start()
    {
        dobraRigidbody = GetComponent<Rigidbody>();
        force = new Vector3(0,3 , 200);

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 position = dobraRigidbody.transform.position;


        if (Input.GetKeyDown(KeyCode.A))
        {

            Debug.Log("sfosdf");

            position.x += 10;

            

            dobraRigidbody.AddForce(force);
        }
    }
}
