using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Transform centerOfMass;
    public List<Axis> Axles;
    public float acceleration = 1;
    public float rotationSpeed = 1;
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.centerOfMass = centerOfMass.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKey(KeyCode.W))
        //{
        //    transform.position += transform.forward * 0.01f;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position += transform.forward * -0.01f;
        //}

        //rigid.AddForce(transform.forward * inputVertical * Time.deltaTime * acceleration);
        //transform.Rotate(new Vector3(0, inputHorizontal * Time.deltaTime * rotationSpeed, 0));

        float inputVertical = Input.GetAxis("Vertical");
        float inputHorizontal = Input.GetAxis("Horizontal");

        foreach(Axis axis in Axles)
        {
            if(axis.canAccelerate)
            {
                axis.leftWheel.motorTorque = inputVertical * acceleration;
                axis.rightWheel.motorTorque = inputVertical * acceleration;
            }
            if (axis.canSteer)
            {
                axis.leftWheel.steerAngle = inputHorizontal * rotationSpeed;
                axis.rightWheel.steerAngle = inputHorizontal * rotationSpeed;
            }
        }
    }
}

[System.Serializable]
public class Axis
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool canAccelerate;
    public bool canSteer;
}