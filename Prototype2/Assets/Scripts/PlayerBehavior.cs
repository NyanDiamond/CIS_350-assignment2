using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*Josh Bonovich
 *Prototype2
 *This script is used to control the player
 */

public class PlayerBehavior : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    private float xRange = 14;

   

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //I decided to switch this one up from the video as its more streamline this way
        if(transform.position.x < -xRange || transform.position.x > xRange)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xRange, xRange), transform.position.y, transform.position.z);
        }
    }
}
