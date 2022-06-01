using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dobradica2 : MonoBehaviour
{


    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitForce = 10000f;
    public float damper = 150f;

    public string inputName;


    HingeJoint hinge;


    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    void Update()
    {

        JointSpring jointSpring = new JointSpring();

        jointSpring.spring = hitForce;
        jointSpring.damper = damper;

        if (Input.GetAxis(inputName) == 1)
        {
            jointSpring.targetPosition = pressedPosition;
        }
        else
        {
            jointSpring.targetPosition = restPosition;
        }


        hinge.spring = jointSpring;
        hinge.useLimits = true;

    }
}
