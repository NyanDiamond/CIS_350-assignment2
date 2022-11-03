using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Project 6 Easy mode
//This script allows for enemies to play a special sound when destroyed
public class EnemyBehavior : Target
{
    //public AudioClip clip;
    // Start is called before the first frame update
    protected override void Die()
    {
        AudioSource.PlayClipAtPoint(Resources.Load<AudioClip>("Right"), FindObjectOfType<Camera>().transform.position);
        base.Die();
    }
}
