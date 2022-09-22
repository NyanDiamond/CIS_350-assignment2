using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Josh Bonovich
//Prototype 3
//this makes the background repeat and seem endless
public class RepeatBackground : MonoBehaviour
{

    private Vector3 startPosition;
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;

        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }
    }
}
