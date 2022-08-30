using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Josh Bonovich    
 * Challenge 1
 * Code to spin the propeller
 */
public class PropellerSpin : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speed);
    }
}
