using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Josh Bonovich
 *Prototype2
 *This script is used to control what happens on collision
 */
public class CollisionBehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        //changed this to be more streamline
        GameObject.FindObjectOfType<DisplayScore>().score += 100; 
        Destroy(gameObject);
    }
}
