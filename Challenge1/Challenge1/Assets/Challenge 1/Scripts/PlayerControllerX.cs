﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Josh Bonovich    
 * Challenge 1
 * Code for the plane to move via player controls
 */
public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        //transform.Translate(Vector3.back * speed);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);

        if (transform.position.y > 80 || transform.position.y < -51)
        {
            GameController.gameOver = true;
        }
    }
}
