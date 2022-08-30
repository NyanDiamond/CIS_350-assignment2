using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Josh Bonovich    
 * Prototype 1
 * Code to control player movement
 */
public class PlayerBehavior : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    public float forwardInput;
    public float horizontalInput;
 

    // Update is called once per frame
    void Update()
    {
        //lets us move foward with forward input
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(transform.forward * Time.deltaTime * speed * forwardInput);
        //lets us turn with horizontal input
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput* turnSpeed *Time.deltaTime);

    }
}
