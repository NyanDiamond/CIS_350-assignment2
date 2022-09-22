using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Prototype 3
//This script moves an object to the left
public class MoveLeft : MonoBehaviour
{
    public float speed = 03f;
    private float leftBound = -15f;
    private PlayerController playerControllerScript;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerControllerScript = GameObject.FindObjectOfType<PlayerController>();
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.Translate(Vector3.left * Time.deltaTime * speed);

        if(!playerControllerScript.gameOver)
        {
            rb.velocity = -Vector3.right * speed;
        }
        else
        {
            rb.velocity = Vector3.zero;
        }

        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        
    }
}
