using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Challenge2
//This script destroys objects once they leave the playing field
public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -40;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
            GameObject.FindObjectOfType<HealthSystem>().TakeDamage();
        }

    }
}
