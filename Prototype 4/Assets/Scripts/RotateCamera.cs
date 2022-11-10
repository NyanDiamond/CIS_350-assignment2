using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Prototype 4
//THis script is to move the camera
public class RotateCamera : MonoBehaviour
{

    public float rotationSpeed;


    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
