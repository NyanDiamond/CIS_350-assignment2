using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Josh Bonovich    
 * Challenge 1
 * Code to increment the score if the player passes through the trigger
 */
public class TriggerBehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            GameController.score++;
            Destroy(gameObject);
        }
    }
}
