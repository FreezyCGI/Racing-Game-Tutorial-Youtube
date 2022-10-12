using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float acceleration = 1;
    public float rotationSpeed = 1;
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
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
        float inputVertical = Input.GetAxis("Vertical");
        float inputHorizontal = Input.GetAxis("Horizontal");

        rigid.AddForce(transform.forward * inputVertical * Time.deltaTime * acceleration);
        transform.Rotate(new Vector3(0, inputHorizontal * Time.deltaTime * rotationSpeed, 0));
    }
}
