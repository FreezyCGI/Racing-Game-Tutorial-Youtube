using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
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
        rigid.AddForce(transform.forward * inputVertical);
    }
}
