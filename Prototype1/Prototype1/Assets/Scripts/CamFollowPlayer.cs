﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Josh Bonovich    
 * Prototype 1
 * Code for the camera to follow the player
 */
public class CamFollowPlayer : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, -10);
   
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
